namespace validaRucEcuador
{
    public static class Constants
    {
        public class RucValidations
        {
            public static int LENGTH_RUC = 13;
            public static string BIN_VALIDATOR_DIGIT = "0-6;9-9";
            public static string BIN_NUMBER_OF_PROVINCES = "01-24;31-31;80-85";
            public static string BIN_LAST_DIGITS_RUC = "001-999";
        }

        public class RegularExpressions
        {            
            public const string NUMBERS = @"^\d+$";            
        }
    }
}
