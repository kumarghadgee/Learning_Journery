namespace _04_00P_Interface
{
    interface IBackendDeveloper
    {
        void Develop();

        void DbCoding();
    }

    interface IFrontendDeveloper
    {
        void Develop();

        void UiCoding();
    }

    class FresherFullStackDeveloper : IFrontendDeveloper , IBackendDeveloper
    {
        public void Develop()
        {
            Console.WriteLine("FresherFullStackDeveloper : DbCoding and UiCoding");
        }

        public void DbCoding()
        {
            Console.WriteLine("FresherFullStackDeveloper : DbCoding");
        }
        
        public void UiCoding()
        {
            Console.WriteLine("FresherFullStackDeveloper : UiCoding");
        }
    }

    class ExperiencedFullStackDeveloper : IFrontendDeveloper, IBackendDeveloper
    {
        public void DbCoding()
        {
            Console.WriteLine("IBackendDeveloper : DbCoding");
        }

        public void UiCoding()
        {
            Console.WriteLine("IFrontendDeveloper : UiCoding");
        }

        void IBackendDeveloper.Develop()
        {
            Console.WriteLine("IBackendDeveloper : Backend");
        }

        void IFrontendDeveloper.Develop()
        {
            Console.WriteLine("IFrontendDeveloper : Frontend");        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FresherFullStackDeveloper
            FresherFullStackDeveloper f1 = new FresherFullStackDeveloper();
            f1.Develop();
            f1.DbCoding();
            f1.UiCoding();
            IBackendDeveloper f2 = f1;
            f2.Develop();
            f2.DbCoding();
            IFrontendDeveloper f3 = f1;
            f3.Develop();
            f3.UiCoding();
            #endregion

            #region ExperiencedFullStackDeveloper
            ExperiencedFullStackDeveloper e1 = new ExperiencedFullStackDeveloper();
            IBackendDeveloper  e2 = e1;
            e2.Develop();
            IFrontendDeveloper e3 = e1;
            e3.Develop();
            #endregion

        }
    }
}
