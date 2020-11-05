namespace DemoCoreApp.Models
{
    public class calc
    {
        public double operand1 {get;set;}
        public double operand2 {get;set;}
        public string strOperator {get;set;}
        public double result {get;set;}

        public calc()
        {
            this.operand1 = 0;
            this.operand2 = 0;
            this.result = 0;
        }

        public void Add(double operand1, double operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.result = operand1 + operand2;
        }
        public void Subtract(double operand1, double operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.result = operand1 - operand2;
        }
    }

}