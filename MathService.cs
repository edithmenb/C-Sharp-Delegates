namespace CSharp_Delegates_master
{
    public class MathService
    {
        public delegate double ResultHandler(double value1, double value2);
        public delegate void OutboundHandler(double result);

        public ResultHandler MathDelegate;
        public OutboundHandler OutboundDelegate;   

        public MathService(){
            MathDelegate = AddNumbers;
            MathDelegate += MultiplyNumbers;
        }

        private double AddNumbers(double value1, double value2)
        {
            var result = value1 + value2;
            OutboundDelegate(result);
            return result;
        }

        private double MultiplyNumbers(double value1, double value2)
        {
            var result = value1 * value2;
            OutboundDelegate(result);
            return result;
        }
    }
}