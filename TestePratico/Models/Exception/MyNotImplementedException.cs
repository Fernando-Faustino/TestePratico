namespace TestePratico.Models.Exception
{
    public class MyNotImplementedException : IOException
    {
        public MyNotImplementedException() : base("Método não implementado.")
        {
            
        }

        public MyNotImplementedException(string message) : base(message)
        {
            
        }

        
    }
}

