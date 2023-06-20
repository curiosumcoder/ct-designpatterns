namespace Northwind.UI
{
    public class HtmlReport : ReportTemplate
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting Html report...");
        }

        protected override void DisplayReport()
        {
            Console.WriteLine("Displaying the Html report...");
        }
    }
}
