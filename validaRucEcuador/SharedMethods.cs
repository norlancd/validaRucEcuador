namespace validaRucEcuador
{
    public static class SharedMethods
    {
        public static bool ValidateInNumericRanges(string data, int valueStartIndex, int valueLength, string valueRanges, string validationName)
        {
            try
            {
                string valueDigits = data.Substring(valueStartIndex, valueLength);
                int value = int.Parse(valueDigits);
                string[] acceptedValues = valueRanges.Split(';');

                for (int i = 0; i < acceptedValues.Length; i++)
                {
                    string[] range = acceptedValues[i].Split('-');
                    int rangeMinValue = int.Parse(range[0]);
                    int rangeMaxValue = int.Parse(range[1]);
                    if ((rangeMinValue <= value) && (rangeMaxValue >= value))
                    {
                        return true;
                    }
                }
                Console.WriteLine($"{validationName} debe estar dentro de los rangos aceptados [{valueRanges}]");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception " + e.ToString());
                return false;
            }           
        }
    }
}
