using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigenbelegToolAlpha
{
    public class TextOperations
    {
        public static int findLine(string[] array, string searchValue)
        {
            int backValue = 0;
            for (int i = 1; i < array.Count(); i++)
            {
                if (array[i].Contains(searchValue))
                {
                    backValue = i + 1;
                    break;
                }
            }
            return backValue;
        }
        public static double getValueOfOneLine(int index, string[] array, int lengthOfTheFirstPos, string firstPos, string secondPos)
        {
            string newValue = "";
            string tempSave = array[index].ToString();
            var fullLength = tempSave.Length;
            var posFirst = tempSave.IndexOf(firstPos);
            var posSecond = tempSave.IndexOf(secondPos);
            string tempValue = tempSave.Substring(posFirst + lengthOfTheFirstPos, posSecond - posFirst - lengthOfTheFirstPos - 1);
            //Erweiterung für Tausenderbeträge mit Leerzeichen
            if (tempValue.Contains(" "))
            {
                var posSpace = tempValue.IndexOf(" ");
                var length = tempValue.Length;
                string temp1 = tempValue.Substring(0, 1);
                string temp2 = tempValue.Substring(posSpace + 1, length - posSpace - 1);
                newValue = temp1 + temp2;
            }
            //Erweiterung für Minusbeträge?
            else if (tempValue.Contains("-"))
            {
                var length = tempValue.Length;
                newValue = tempValue.Substring(0, length - 1);
            }
            else if (tempValue == "0,00")
            {
                newValue = "0";
            }
            else
            {
                newValue = tempValue;
            }

            double value = Convert.ToDouble(newValue);
            return value;
        }

        public static double getValueOfOneLineEbayFormat(int index, string[] array, int lengthOfTheFirstPos, string firstPos)
        {
            string newValue = "";
            string tempSave = array[index].ToString();
            var fullLength = tempSave.Length;
            var posFirst = tempSave.IndexOf(firstPos);
            string tempValue = tempSave.Substring(posFirst + lengthOfTheFirstPos, fullLength-posFirst-lengthOfTheFirstPos);

            //Erweiterung für Minusbeträge?
            if (tempValue.Contains("-"))
            {
                var length = tempValue.Length;
                newValue = tempValue.Substring(0, length - 1);
            }
            else if (tempValue == "0,00")
            {
                newValue = "0";
            }
            else
            {
                newValue = tempValue;
            }
            double value = Convert.ToDouble(newValue);
            return value;
        }
    }
}
