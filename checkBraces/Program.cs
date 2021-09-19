using static System.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _16._09._2021
{
    class Program
    {
        static bool CheckBraces(string str)
        {
            // Инициализация stack
            Stack braces = new Stack();

            // Заполняем stack
            // если скобки имеются, то их не вносим и сразу удаляем
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == ')' || str[i] == '}' || str[i] == ']') && braces.Count > 0)
                {
                    if (Convert.ToChar(braces.Peek()) == '(' ||
                        Convert.ToChar(braces.Peek()) == '{' ||
                        Convert.ToChar(braces.Peek()) == '[')
                        braces.Pop();
                }

                else braces.Push(str[i]);
            }

            // возвращаем значение
            if (braces.Count > 0) return false;
            else return true;
        }

        static void Main(string[] args)
        {
            string str = "{}()()()[]{";
            Console.WriteLine(CheckBraces(str));

            string str2 = "{}()[][]";
            Console.WriteLine(CheckBraces(str2));
        }
    }
}