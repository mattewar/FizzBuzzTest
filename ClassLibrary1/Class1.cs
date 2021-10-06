using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public List<string> PrintList(int count, List<ModPair> conditions)
        {
            if (count > int.MaxValue / 8)
            {
                throw new Exception("Invalid length for list printing, use the Print() method instead");
            }
            if(count < 0)
            {
                throw new Exception("Negative numbers are invalid");
            }
            var list = new List<string>(count);
            for (int i = 1; i <= count; i++)
            {
                list.AddRange(Print(i, conditions));
            }
            return list;
        }

        public List<string> Print(int number, List<ModPair> conditions)
        {
            if (number < 0)
            {
                throw new Exception("Negative numbers are invalid");
            }
            var list = new List<string>();
            foreach(var condition in conditions)
            {
                if(number % condition.Number == 0)
                {
                    list.Add(condition.Word);
                }
            }

            if (list.Count == 0)
            {
                list.Add(number.ToString());
            }

            return list;
        }
    }
}
