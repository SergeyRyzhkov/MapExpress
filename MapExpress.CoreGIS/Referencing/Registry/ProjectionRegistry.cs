using System.Collections.Generic;
using MapExpress.CoreGIS.Referencing.Operations.Projections;

namespace MapExpress.CoreGIS.Referencing.Registry
{
    // TODO: Регистри и в соотв. папку
    // TODO :а где SphericalMercator?
	
	вынести в отдельный проект? Оставить торлько интерфейсы?

    public class ProjectionRegistry : AuthorityObjectRegistry <Projection>
    {
        private static readonly List <Projection> projections = new List <Projection> ();
        private static ProjectionRegistry instance;
        public AlbersConicEqualArea AlbersConicEqualArea = new AlbersConicEqualArea (null);
        public AzimuthalEquidistant AzimuthalEquidistant = new AzimuthalEquidistant (null);
        public CassiniSoldner CassiniSoldner = new CassiniSoldner (null);
        public Eckert1 Eckert1 = new Eckert1 (null);
        public Eckert2 Eckert2 = new Eckert2 (null);
        public Eckert3 Eckert3 = new Eckert3 (null);
        public Eckert4 Eckert4 = new Eckert4 (null);
        public Eckert5 Eckert5 = new Eckert5 (null);
        public Eckert6 Eckert6 = new Eckert6 (null);
        public EquidistantConic EquidistantConic = new EquidistantConic (null);
        public EquidistantCylindrical EquidistantCylindrical = new EquidistantCylindrical (null);
        public Gnomonic Gnomonic = new Gnomonic (null);
        public Krovak Krovak = new Krovak (null);
        public LambertAzimuthalEqualArea LambertAzimuthalEqualArea = new LambertAzimuthalEqualArea (null);
        public LambertConformalConic LambertConformalConic = new LambertConformalConic (null);
        public LambertCylindricalEqualArea LambertCylindricalEqualArea = new LambertCylindricalEqualArea (null);
        public Mercator1SP Mercator1SP = new Mercator1SP (null);
        public Mercator2SP Mercator2SP = new Mercator2SP (null);
        public MillerCylindrical MillerCylindrical = new MillerCylindrical (null);
        public Mollweide Mollweide = new Mollweide (null);
        public ObliqueMercator ObliqueMercator = new ObliqueMercator (null);
        public ObliqueStereographic ObliqueStereographic = new ObliqueStereographic (null);
        public PolarStereographic PolarStereographic = new PolarStereographic (null);
        public TransverseMercator TransverseMercator = new TransverseMercator ();
        public VanDerGrinten VanDerGrinten = new VanDerGrinten (null);
        public Wagner2 Wagner2 = new Wagner2 (null);


        // TODO: Приделать все алиасы
        // TODO: Обязательно инициализировать константы!

        private ProjectionRegistry ()
        {
            projections.Add (Mercator1SP);
            projections.Add (Mercator2SP);

            TransverseMercator.InitAuthorityAliases ();
            projections.Add (TransverseMercator);

            projections.Add (Krovak);
            projections.Add (AlbersConicEqualArea);
            projections.Add (AzimuthalEquidistant);
            projections.Add (ObliqueMercator);
            projections.Add (LambertAzimuthalEqualArea);
            projections.Add (Eckert1);
            projections.Add (Eckert2);
            projections.Add (Eckert3);
            projections.Add (Eckert4);
            projections.Add (Eckert5);
            projections.Add (Eckert6);
            projections.Add (CassiniSoldner);
            projections.Add (LambertCylindricalEqualArea);
            projections.Add (MillerCylindrical);
            projections.Add (VanDerGrinten);
            projections.Add (ObliqueStereographic);
            projections.Add (EquidistantCylindrical);
            projections.Add (EquidistantConic);
            projections.Add (Mollweide);
            projections.Add (Gnomonic);
            projections.Add (LambertConformalConic);
            projections.Add (PolarStereographic);
            projections.Add (Wagner2);
        }

        public override IList <Projection> All
        {
            get { return projections; }
        }

        public static ProjectionRegistry Instance
        {
            get { return instance ?? (instance = new ProjectionRegistry ()); }
        }
    }
}