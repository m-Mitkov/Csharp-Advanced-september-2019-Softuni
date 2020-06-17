using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICaller, IBrowser
    {
        public string Call(string number)
        {
            if (NumberValidator(number))
            {
                if (number.Length == 10)
                {
                    return $"Calling... {number}";
                }

                return $"Dialing... {number}";
            }

            return "Invalid number!";
        }

        public string LoadPage(string URL)
        {
            if (BrowserValidator(URL))
            {
                return $"Browsing: {URL}!";
            }

            return "Invalid URL!";
        }


        private bool BrowserValidator(string URL)
        {
            string patternValidURLAdress = @"http:\/\/[A-Za-z]+\.[a-z]+\b";
            Regex URLValidator = new Regex(patternValidURLAdress);

            if (URLValidator.IsMatch(URL))
            {
                return true;
            }

            return false;
        }
        private bool NumberValidator(string number)
        {
            string patternValideNumber = @"\b[0-9]+\b";
            Regex patternForNumber = new Regex(patternValideNumber);

            if (patternForNumber.IsMatch(number))
            {
                return true;
            }

            return false;
        }
    }
}
