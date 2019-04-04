using System;

namespace udemyApp
{
    public class InputConverter
    {
        public double convertInputToNumeric(string input)
        {
            double convertedNumber;
            if (!double.TryParse(input, out convertedNumber)) throw new ArgumentException("Expected a numberic value");
            return convertedNumber;
        }
    }
}