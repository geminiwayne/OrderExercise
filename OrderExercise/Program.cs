using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrderExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order Mangement System");
            Console.WriteLine("1. Add order 2. Display output 3. Exit");
            Console.WriteLine("---------------------------------------");
            List<String> opList = new List<String>();
            Program p = new Program();
            String input;
            while ((input = Console.ReadLine()) != "3")
            {
                switch (input)
                {
                    case "1":
                        opList = p.OrderInput();
                        Console.WriteLine("The order list was created.");
                        break;
                    case "2":
                        p.OrderManage(opList);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Please input the valid number.");
                        break;
                }
            }

        }

        // input and check the valid with regex
        private List<String> OrderInput()
        {
            Console.WriteLine("Please input the order list(eg. 10 SHA9 and # to exit):");
            List<String> orderList = new List<String>();
            String input;

            while ((input = Console.ReadLine()) != "#")
            {
                String regex = "[0-9]+ [0-9a-zA-Z]+";
                var match = Regex.Match(input, regex);

                if (!match.Success)
                {
                    Console.WriteLine("Input is not valid, please try again.");
                }
                else
                {
                    orderList.Add(input);
                    Console.WriteLine("Order was added into the list.");
                }
            }
            return orderList;
        }

        // manage the order list and display output
        private void OrderManage(List<String> tempList)
        {
            List<String> outputList = new List<String>();
            foreach (var item in tempList)
            {
                List<String> subOrderList = PackCalculator(item);
                outputList.AddRange(subOrderList);
            }
            foreach (var output in outputList)
            {
                Console.WriteLine(output);
            }

        }

        //input the pack and total number and get the packNum and remainder
        private Tuple<int, int> Calculator(int pack, int total)
        {
            int packNum = total / pack;
            int remainder = total - pack * packNum;
            return Tuple.Create(packNum, remainder);
        }

        // pack calculatOr and return the suitable pack info
        private List<String> PackCalculator(String orderItem)
        {
            List<String> tempList = new List<String>();
            String[] splittedArr = orderItem.Split(' ');
            int budgetNum = 0;
            Double totalCost = 2147483647;
            Int32.TryParse(splittedArr[0], out budgetNum);
            switch (splittedArr[1])
            {
                case "SH3":
                    int mediumMaxSH = (budgetNum / 5) + 1;
                    int smallmMaxSH = (budgetNum / 3) + 1;
                    int medPackNum = 0;
                    int smaPackNum = 0;

                    for (var j = 0; j < smallmMaxSH; j++)
                    {
                        for (var i = 0; i < mediumMaxSH; i++)
                        {
                            if (5 * i + 3 * j == budgetNum)
                            {
                                Double sum = 4.49 * i + 2.99 * j;
                                if (sum < totalCost)
                                {
                                    totalCost = sum;
                                    medPackNum = i;
                                    smaPackNum = j;
                                }
                            }
                        }
                    }
                    tempList.Add(orderItem + " $" + (totalCost).ToString());
                    if (medPackNum != 0)
                    {
                        tempList.Add(medPackNum.ToString() + "*5 $" + (4.49 * medPackNum).ToString());
                    }
                    if (smaPackNum != 0)
                    {
                        tempList.Add(smaPackNum.ToString() + "*3 $" + (2.99 * smaPackNum).ToString());
                    }
                    break;
                case "YT2":
                    int largeMaxYT = (budgetNum / 15) + 1;
                    int mediumMaxYT = (budgetNum / 10) + 1;
                    int smallmMaxYT = (budgetNum / 4) + 1;
                    int medPackNumYT = 0;
                    int smaPackNumYT = 0;
                    int largePackNumYT = 0;
                    for (var k = 0; k < smallmMaxYT; k++)
                    {
                        for (var j = 0; j < mediumMaxYT; j++)
                        {
                            for (var i = 0; i < largeMaxYT; i++)
                            {
                                if (15 * i + 10 * j + 4 * k == budgetNum)
                                {
                                    Double sum = 13.95 * i + 9.95 * j + 4.95 * k;
                                    if (sum < totalCost)
                                    {
                                        totalCost = sum;
                                        largePackNumYT = i;
                                        medPackNumYT = j;
                                        smaPackNumYT = k;

                                    }
                                }
                            }
                        }
                    }

                    tempList.Add(orderItem + " $" + (totalCost).ToString());
                    if (largePackNumYT != 0)
                    {
                        tempList.Add(largePackNumYT.ToString() + "*15 $" + (13.95 * largePackNumYT).ToString());
                    }
                    if (medPackNumYT != 0)
                    {
                        tempList.Add(medPackNumYT.ToString() + "*10 $" + (9.95 * medPackNumYT).ToString());
                    }
                    if (smaPackNumYT != 0)
                    {
                        tempList.Add(smaPackNumYT.ToString() + "*4 $" + (4.95 * smaPackNumYT).ToString());
                    }
                    break;
                case "TR":
                    int largeMaxTR = (budgetNum / 9) + 1;
                    int mediumMaxTR = (budgetNum / 5) + 1;
                    int smallmMaxTR = (budgetNum / 3) + 1;
                    int medPackNumTR = 0;
                    int smaPackNumTR = 0;
                    int largePackNumTR = 0;
                    for (var k = 0; k < smallmMaxTR; k++)
                    {
                        for (var j = 0; j < mediumMaxTR; j++)
                        {
                            for (var i = 0; i < largeMaxTR; i++)
                            {
                                if (9 * i + 5 * j + 3 * k == budgetNum)
                                {
                                    Double sum = 7.99 * i + 4.45 * j + 2.95 * k;
                                    if (sum < totalCost)
                                    {
                                        totalCost = sum;
                                        largePackNumTR = i;
                                        medPackNumTR = j;
                                        smaPackNumTR = k;

                                    }
                                }
                            }
                        }
                    }

                    tempList.Add(orderItem + " $" + (totalCost).ToString());

                    if (largePackNumTR != 0)
                    {
                        tempList.Add(largePackNumTR.ToString() + "*9 $" + (7.99 * largePackNumTR).ToString());
                    }
                    if (medPackNumTR != 0)
                    {
                        tempList.Add(medPackNumTR.ToString() + "*5 $" + (4.45 * medPackNumTR).ToString());
                    }
                    if (smaPackNumTR != 0)
                    {
                        tempList.Add(smaPackNumTR.ToString() + "*3 $" + (2.95 * smaPackNumTR).ToString());
                    }
                    break;
            }
            return tempList;
        }
    }
}
