using System;
using System.Globalization;
using System.IO;
using System.Text;

public enum TokenType
{
    Word,
    Number,
    Eol,
    Eof,
    Whitespace,
    Symbol
}

namespace MapExpress.CoreGIS.Utils
{
    public class StreamTokenizer
    {
        private static ASCIIEncoding asciIIEncoding = new ASCIIEncoding ();
        private readonly bool ignoreWhitespace;
        private readonly TextReader reader;
        private int colNumber = 1;
        private string currentToken;
        private TokenType currentTokenType;
        private int lineNumber = 1;

        public StreamTokenizer (TextReader reader, bool ignoreWhitespace)
        {
            if (reader == null)
            {
                throw new ArgumentNullException ("reader");
            }
            this.reader = reader;
            this.ignoreWhitespace = ignoreWhitespace;
        }

        public int LineNumber
        {
            get { return lineNumber; }
        }

        public int Column
        {
            get { return colNumber; }
        }


        public double GetNumericValue ()
        {
            string number = GetStringValue ();
            if (GetTokenType () == TokenType.Number)
                return double.Parse (number, CultureInfo.InvariantCulture.NumberFormat);
            throw new ArgumentException (String.Format (CultureInfo.InvariantCulture.NumberFormat, "The token '{0}' is not a number at line {1} column {2}.",
                                                        number, LineNumber, Column));
        }

        public string GetStringValue ()
        {
            return currentToken;
        }

        public TokenType GetTokenType ()
        {
            return currentTokenType;
        }

        public TokenType NextToken (bool ignoreWhitespace)
        {
            var nextTokenType = ignoreWhitespace ? NextNonWhitespaceToken () : NextTokenAny ();
            return nextTokenType;
        }

        public void ReadToken (string expectedToken)
        {
            NextToken ();
            if (GetStringValue () != expectedToken)
            {
                throw new ArgumentException (String.Format (CultureInfo.InvariantCulture.NumberFormat, "Expecting ('{3}') but got a '{0}' at line {1} column {2}.", GetStringValue (), LineNumber, Column, expectedToken));
            }
        }

        public string ReadDoubleQuotedWord ()
        {
            var word = "";
            ReadToken ("\"");
            NextToken (false);
            while (GetStringValue () != "\"")
            {
                word = word + GetStringValue ();
                NextToken (false);
            }
            return word;
        }

        public TokenType NextToken ()
        {
            return NextToken (ignoreWhitespace);
        }

        private TokenType NextTokenAny ()
        {
            var chars = new char[1];
            currentToken = "";
            currentTokenType = TokenType.Eof;
            var finished = reader.Read (chars, 0, 1);

            var isNumber = false;
            var isWord = false;
            //var ae = new ASCIIEncoding ();

            while (finished != 0)
            {
                var ba = new[] {(byte) reader.Peek ()};
                var ascii = asciIIEncoding.GetChars (ba);
                var currentCharacter = chars [0];
                var nextCharacter = ascii [0];
                currentTokenType = GetType (currentCharacter);
                var nextTokenType = GetType (nextCharacter);
                if (isWord && currentCharacter == '_')
                {
                    currentTokenType = TokenType.Word;
                }
                if (isWord && currentTokenType == TokenType.Number)
                {
                    currentTokenType = TokenType.Word;
                }
                if (currentTokenType == TokenType.Word && nextCharacter == '_')
                {
                    nextTokenType = TokenType.Word;
                    isWord = true;
                }
                if (currentTokenType == TokenType.Word && nextTokenType == TokenType.Number)
                {
                    nextTokenType = TokenType.Word;
                    isWord = true;
                }
                if (currentCharacter == '-' && nextTokenType == TokenType.Number && isNumber == false)
                {
                    currentTokenType = TokenType.Number;
                    nextTokenType = TokenType.Number;
                }
                if (isNumber && nextTokenType == TokenType.Number && currentCharacter == '.')
                {
                    currentTokenType = TokenType.Number;
                }
                if (currentTokenType == TokenType.Number && nextCharacter == '.' && isNumber == false)
                {
                    nextTokenType = TokenType.Number;
                    isNumber = true;
                }
                colNumber++;
                if (currentTokenType == TokenType.Eol)
                {
                    lineNumber++;
                    colNumber = 1;
                }
                currentToken = currentToken + currentCharacter;
                if (currentTokenType != nextTokenType)
                {
                    finished = 0;
                }
                else if (currentTokenType == TokenType.Symbol && currentCharacter != '-')
                {
                    finished = 0;
                }
                else
                {
                    finished = reader.Read (chars, 0, 1);
                }
            }
            return currentTokenType;
        }

        private static TokenType GetType (char character)
        {
            if (Char.IsDigit (character))
            {
                return TokenType.Number;
            }
            if (Char.IsLetter (character))
            {
                return TokenType.Word;
            }
            if (character == '\n')
            {
                return TokenType.Eol;
            }
            if (Char.IsWhiteSpace (character) || Char.IsControl (character))
            {
                return TokenType.Whitespace;
            }
            return TokenType.Symbol;
        }

        private TokenType NextNonWhitespaceToken ()
        {
            var tokentype = NextTokenAny ();
            while (tokentype == TokenType.Whitespace || tokentype == TokenType.Eol)
            {
                tokentype = NextTokenAny ();
            }
            return tokentype;
        }
    }
}