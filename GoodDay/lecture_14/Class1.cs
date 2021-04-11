using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_14
{
    public static class StringExtension
    {
        public static string CharCut(this string str)
        {
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                result = string.Concat(result, str[i]);                
            }
            return string.Concat(result,"...");
        }
    }
} 
