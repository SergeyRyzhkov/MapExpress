#region

using System.Threading.Tasks;

#endregion

// TODO: В отдельную сборку все утилиты

namespace MapExpress.CoreGIS.Utils
{
    //Parallel.For - убрать
    public class Matrix
    {
        private readonly double[,] innerArray;

        public Matrix (int rowCount = 1, int columnCount = 1)
        {
            innerArray = new double[rowCount,columnCount];
            ColumnCount = columnCount;
            RowCount = rowCount;
        }

        public double this [int x, int y]
        {
            get { return innerArray [x, y]; }
            set { innerArray [x, y] = value; }
        }

        public int ColumnCount { get; private set; }

        public int RowCount { get; private set; }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix (m1.RowCount, m2.ColumnCount);

            Parallel.For (0, resultMatrix.RowCount, i =>
                                                        {
                                                            for (int j = 0; j < resultMatrix.ColumnCount; j++)
                                                            {
                                                                for (int k = 0; k < m1.ColumnCount; k++)
                                                                {
                                                                    resultMatrix [i, j] += m1 [i, k] * m2 [k, j];
                                                                }
                                                            }
                                                        }
                );

            return resultMatrix;
        }

        public static Matrix operator * (double constNum, Matrix m1)
        {
            var resultMatrix = new Matrix (m1.RowCount, m1.ColumnCount);

            Parallel.For (0, m1.RowCount, i =>
                                              {
                                                  for (int j = 0; j < m1.ColumnCount; j++)
                                                  {
                                                      resultMatrix [i, j] = m1 [i, j] * constNum;
                                                  }
                                              }
                );
            return resultMatrix;
        }

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix (m1.RowCount, m1.ColumnCount);
            Parallel.For (0, resultMatrix.RowCount, i =>
                                                        {
                                                            for (int j = 0; j < resultMatrix.ColumnCount; j++)
                                                            {
                                                                resultMatrix [i, j] = m1 [i, j] + m2 [i, j];
                                                            }
                                                        }
                );


            return resultMatrix;
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix (m1.RowCount, m1.ColumnCount);
            Parallel.For (0, resultMatrix.RowCount, i =>
            {
                for (int j = 0; j < resultMatrix.ColumnCount; j++)
                {
                    resultMatrix[i, j] = m1[i, j] - m2[i, j];
                }
            }
                );


            return resultMatrix;
        }
    }
}