namespace Northwind.Data
{
    public class DataCommandInvoker
    {
        ICommand comm;

        public DataCommandInvoker(ICommand comm) { 
            this.comm = comm;
        }

        public void ChangeCommand(ICommand comm)
        {
            this.comm = comm;
        }

        public void ExecuteCommand()
        {
            this.comm.Execute();
        }            
    }
}
