using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrderExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

        }

        // get number and item name
        private String Splitter(String item)
        {
            String[] splittedItem = item.Split(' ');
            return null;
        }

        // input and check the valid with regex
        private List<String> OrderInput()
        {
            List<String> orderList = new List<String>();
            String input = Console.ReadLine();
            String regex = "[0-9]+ [0-9a-zA-Z]+";

            var match = Regex.Match(input, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                Console.WriteLine("Input is not valid, please try again.");
            }
            else
            {
                orderList.Add(input);
                Console.WriteLine("Order list was created.");
                return orderList;

            }
            return null;
        }

        // return the output list
        private List<String> OrderManage(List<String> tempList)
        {

            return null;
        }

        // pack calculatOr and return the suitable pack info
        private List<String> PackCalculator(String orderItem)
        {
            return null;
        }
    }
}
