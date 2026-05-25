namespace _01_OOP_Revision
{
    public abstract class Report
    {
        protected abstract void Create();
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            Create();
            Parse();
            Validate();
            Save();
        }
    }

    public class PDFReport : Report
    {
        protected override void Create()
        {
            Console.WriteLine("PDF Report Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("PDF Report Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("PDF Report Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF Report Saved");
        }

    }

    public class DOCXReport : Report
    {
        protected override void Create()
        {
            Console.WriteLine("DOCX Report Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("DOCX Report Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("DOCX Report Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("DOCX Report Saved");
        }
    }

    public class XMLReport : Report
    {
        protected override void Create()
        {
            Console.WriteLine("XML Report Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("XML Report Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("XML Report Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("XML Report Saved");
        }
    }

    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Create();
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }
    public class JSONReport : SpecialReport
    {
        protected override void Create()
        {
            Console.WriteLine("JSON Report Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("JSON Report Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("JSON Report Validated");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("JSON Report Re-Validate");
        }

        protected override void Save()
        {
            Console.WriteLine("JSON Report Saved");
        }

        
    }

    public class BSONReport : SpecialReport
    {
        protected override void Create()
        {
            Console.WriteLine("BSON Report Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("BSON Report Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("BSON Report Validated");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("BSON Report Re-Validate");
        }

        protected override void Save()
        {
            Console.WriteLine("BSON Report Saved");
        }
    }

    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            if(choice == 1)
            {
                return new PDFReport();
            }
            else if(choice == 2)
            {
                return new DOCXReport();
            }
            else if(choice == 3)
            {
                return new XMLReport();
            }
            else if (choice == 4)
            {
                return new BSONReport();
            }
            else
            {
                return new JSONReport();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //PDFReport report = new PDFReport();
            //report.GenerateReport();
            //DOCXReport dreport = new DOCXReport();
            //dreport.GenerateReport();
            //JSONReport jr = new JSONReport();
            //jr.GenerateReport();

            ReportFactory factory = new ReportFactory();

            Console.WriteLine("1.PDF  2.DOCX  3.XML  4.BSON  5.JSON");
            int choice = int.Parse(Console.ReadLine());

            Report report = factory.GetReport(choice);
            report.GenerateReport();

            Console.ReadLine(); 
        }
    }
}
