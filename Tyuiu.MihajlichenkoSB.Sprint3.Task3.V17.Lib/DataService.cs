using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Input cannot be null.");

            int result = 0;
            foreach (char c in value) 
            {
                if (char.IsDigit(c))
                {
                    result = result * 10 + (c - '0');
                }
            }

            if (result == 0)
                throw new ArgumentException("No digits found in input.");

            return result;
        }
    }
}