using System.Text.RegularExpressions;

namespace validaRucEcuador
{
    public static class ValidateRUC
    {
        public static bool Validate(string ruc)
        {
            string reg_string = Constants.RegularExpressions.NUMBERS;
            string quantifier = "{" + Constants.RucValidations.LENGTH_RUC + "," + Constants.RucValidations.LENGTH_RUC + "}";
            reg_string += quantifier;
            Regex reg = new Regex(reg_string);
            Match match = reg.Match(ruc);
            if (match.Length != ruc.Length)
            {
                Console.WriteLine($"No cumple con la expresion regular {reg_string}");
                return false;
            }
            else
            {
                #region Validate Provinces
                if (!SharedMethods.ValidateInNumericRanges(ruc, 0, 2, Constants.RucValidations.BIN_NUMBER_OF_PROVINCES, nameof(Constants.RucValidations.BIN_NUMBER_OF_PROVINCES))) //"01-24;31-31;80-85";
                {
                    return false;
                }
                #endregion Validate Provinces

                #region Validate Validator Digit
                if (!SharedMethods.ValidateInNumericRanges(ruc, 2, 1, Constants.RucValidations.BIN_VALIDATOR_DIGIT, nameof(Constants.RucValidations.BIN_VALIDATOR_DIGIT))) //"0-6;9-9";
                {
                    return false;
                }
                #endregion Validate Validator Digit

                #region Validate Branch Digits
                if (!SharedMethods.ValidateInNumericRanges(ruc, 10, 3, Constants.RucValidations.BIN_LAST_DIGITS_RUC, nameof(Constants.RucValidations.BIN_LAST_DIGITS_RUC))) //"001-999";
                {
                    return false;
                }
                #endregion Validate Branch Digits   
            }
            return true;
        }
    }
}
