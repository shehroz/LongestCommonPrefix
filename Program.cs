using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr={"flower", "flow", "flight"};
            //string[] arr = { "dog", "racecar", "car" };
            //string[] arr = {""};
            string[] arr = {"caa","","a","acb"};
            Console.WriteLine(LongestCommonPrefix(arr));
            Console.ReadKey();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            var commonPrefix = "";
            if (strs.Length == 0)

                return commonPrefix;
            else if (strs.Length==1 && strs[0].Length <= 1)
                return strs[0];

            int index = 0;
            bool IsFound = false;
            var c = "";
            while (IsFound==false)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j].Length > index && strs[j + 1].Length > index && strs[j].Substring(index, 1) == strs[j + 1].Substring(index, 1))
                        c = strs[j].Substring(index, 1);
                    else
                    {
                        c = "";
                        IsFound = true;
                        break;
                    }
                }
                if(c!="")
                    commonPrefix += c;
                index++;
            }

            return commonPrefix;
            
        }
        
    }

}
