using System.Collections.Generic;
using System.Linq;

namespace TSStringAverage
{
    public class TSStringAverage
    {
        public string StringAverage(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "n/a";
            }

            List<string> strList = new List<string>();
            strList = str.ToLower().Split(' ').ToList<string>();

            var sum = 0;
            foreach (var num_str in strList)
	        {
                switch (num_str)
                {
                    case "zero":
                        break;
                    case "one":
                        sum += 1;
                        break;
                    case "two":
                        sum += 2;
                        break;
                    case "three":
                        sum += 3;
                        break;
                    case "four":
                        sum += 4;
                        break;
                    case "five":
                        sum += 5;
                        break;
                    case "six":
                        sum += 6;
                        break;
                    case "seven":
                        sum += 7;
                        break;
                    case "eight":
                        sum += 8;
                        break;
                    case "nine":
                        sum += 9;
                        break;
                    default:
                        return "n/a";
                }
        	}

            int result = sum / strList.Count;

            switch (result)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "n/a";
            }
        }
    }
}
