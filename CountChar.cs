﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class CountChar
    {
        public static void PrintCount()
        {
            string str = "hi how are you";
            str = str.Replace(" ","");


            while (str.Length > 0)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($" {str[0]} : {count}");
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}