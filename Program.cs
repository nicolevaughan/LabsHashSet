namespace LabsHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> BMP = new HashSet<string>();
            BMP.Add("CAL");
            BMP.Add("CH");
            BMP.Add("CRE");
            BMP.Add("GLU");
            BMP.Add("K");
            BMP.Add("NA");
            BMP.Add("TCO2");
            BMP.Add("BUN");

            HashSet<string> Hepatic = new HashSet<string>();
            Hepatic.Add("ALT");
            Hepatic.Add("ALB");
            Hepatic.Add("ALP");
            Hepatic.Add("AST");
            Hepatic.Add("DBIL");
            Hepatic.Add("TBIL");
            Hepatic.Add("TPRO");

            HashSet<string> CMP = new HashSet<string>();
            CMP.Add("ALT");
            CMP.Add("ALB");
            CMP.Add("ALP");
            CMP.Add("AST");
            CMP.Add("CAL");
            CMP.Add("CH");
            CMP.Add("CRE");
            CMP.Add("GLU");
            CMP.Add("K");
            CMP.Add("NA");
            CMP.Add("TBIL");
            CMP.Add("TCO2");
            CMP.Add("TPRO");
            CMP.Add("BUN");

            Console.WriteLine("Combined list of Basic Metabolic Panel and Hepatic Function tests");
            BMP.UnionWith(Hepatic);
            foreach (string tests in BMP)
            {
                Console.WriteLine(tests);
            }
            Console.WriteLine();

            Console.WriteLine("Tests that are in both Comprehensive Metabolic Panel and combined list");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = BMP;
            bothLists.IntersectWith(CMP);
            foreach (string tests in bothLists)
            {
                Console.WriteLine(tests);
            }
        }
    }
}