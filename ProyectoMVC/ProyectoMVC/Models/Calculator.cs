namespace ProyectoMVC.Models
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int add()
        {
            
            return FirstNumber + SecondNumber;
        }
    }
}
