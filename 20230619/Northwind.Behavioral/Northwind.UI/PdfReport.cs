namespace Northwind.UI
{
    public class PdfReport : ReportTemplate
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting Pdf report...");
        }
    }
}
