namespace DataProvider.Models
{
    public class Change
    {
        public decimal ChangeValue { get; set; }
        public PropertyType PropertyType { get; set; }
        public MathOperation MathOperation { get; set; }

        public override string ToString()
        {
            return PropertyType + getStringForMathOp(MathOperation) + ChangeValue;
        }
        private string getStringForMathOp(MathOperation changeMathOperation)
        {
            switch (changeMathOperation)
            {
                case MathOperation.Add:
                    return " + ";
                case MathOperation.Div:
                    return " / ";
                case MathOperation.Multi:
                    return " * ";
                case MathOperation.Subtract:
                    return " - ";
                default:
                    return " * ";
            }
        }
    }
    
}