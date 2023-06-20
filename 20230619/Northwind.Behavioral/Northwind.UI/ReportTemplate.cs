namespace Northwind.UI
{
    /// <summary>
    /// Template Method
    /// </summary>
    public abstract class ReportTemplate
    {
        public void GenerateReport()
        {
            CollectData();
            FormatReport();
            DisplayReport();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void CollectData();
        protected abstract void FormatReport();

        // Default implementation of displaying the report
        protected virtual void DisplayReport()
        {
            Console.WriteLine("Displaying the product report...");
        }
    }
}
