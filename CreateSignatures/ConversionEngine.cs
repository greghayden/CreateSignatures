using System.Diagnostics;


namespace CreateSignatures
{
    public class ConversionEngine
    {
        const int ADDITION_FACTOR = 100;
        const int PRODUCT_FACTOR = 100000;
        /// <summary>
        /// StringConversion takes a string and returns a Tuple<int, int, int> by calling
        /// convertWord(). The tuple's item2 (product) and item3 (addition) are returned 
        /// by multiplying their associated FACTOR constants and converting their values 
        /// to integers. The length is simply passed through as an integer.
        /// This is a consolidation of previous separate methods.
        /// <param name="word"></param>
        /// <returns>A Tuple<int, int, int> named ConvertedTuple</returns>
        /// </summary>
        public Tuple<int, int, int> StringConversion(string word)
        {
            if (!string.IsNullOrEmpty(word.ToLower()))
            {
                Int32 length, product, addition;
                try
                {
                    var ConvertedTuple = ConvertWord(word);

                    length = ConvertedTuple.Item1;
                    product = Convert.ToInt32(PRODUCT_FACTOR * ConvertedTuple.Item2);
                    Debug.Assert(product > 0 && product < 2000000);
                    addition = Convert.ToInt32(ADDITION_FACTOR * ConvertedTuple.Item3);
                    Debug.Assert(product > 0 && product < 2000000);

                    return Tuple.Create(length, product, addition);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);   
                }
            }
            else
            {
                throw new System.ArgumentNullException("String Conversion method was passed a null or empty string.");
            }
        }

        /// <summary>
        /// ConvertWord takes a string and returns a Tuple<int, double, double> by getting the 
        /// signatures of the Product and Sumation of the inputted word using getCharValue() and 
        /// then adds the calculated length to the returned Tuple.
        /// This is a consolidation of previous separate methods.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private Tuple<int, double, double> ConvertWord(string word)
        {
            double retProd = 1.000;
            double retSum = 0.000;
            int retLen = word.Length;
            int pos = 0;
            string lowercaseWord = word.ToLower();

            if (!string.IsNullOrEmpty(lowercaseWord.Trim()))
            {
                pos = ((lowercaseWord.Trim().Length) - 1); // string is zero based array
                Debug.Assert(pos >= 0);
                while (pos >= 0)
                {
                    retProd *= GetCharValue((lowercaseWord.Substring(pos, 1)).ToCharArray());
                    //Console.WriteLine($"Current Product Value: {retProd}");
                    retSum += GetCharValue((lowercaseWord.Substring(pos, 1)).ToCharArray());
                    //Console.WriteLine($"Current Addition Value: {retSum}");
                    pos--;
                    Debug.Assert(retProd > 0 && retProd < 2000000);
                    Debug.Assert(retSum > 0 && retSum < 2000);
                }
            }

            return Tuple.Create(retLen, retProd, retSum);
        }

        /// <summary>
        /// GetCharValue takes a character array of one element (converted from string[0]) and
        /// using the ascii value, calculates an offset and adds the offset to 1. This results 
        /// in a number between 1 and 2. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private double GetCharValue(char[] s)
        {
            char c = s[0];
            //Console.WriteLine($"Current Character Value: {c}");
            double number = (1 + ((c - 96) * 0.004));
            //Console.WriteLine($"Current Number Value: {number}");
            return number;
        }







    }
}