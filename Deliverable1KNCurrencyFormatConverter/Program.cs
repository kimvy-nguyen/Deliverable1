using System;

namespace Deliverable1KNCurrencyFormatConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double amount1, amount2, amount3;
            Console.Write("Enter the First dollar amount: ");
            amount1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second dollar amount: ");
            amount2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Third dollar amount: ");
            amount3 = Convert.ToDouble(Console.ReadLine());

            double result = (amount1 + amount2 + amount3) / 3;
            Console.WriteLine("The Average of {0}, {1}, {2} is: {3} ",
         amount1, amount2, amount3, result);

            double total = amount1 + amount2 + amount3;



            Console.WriteLine("The Smallest amount:" + Math.Min(amount1, Math.Min(amount2, amount3)));
            Console.WriteLine("The Largest amount:" + Math.Max(amount1, Math.Max(amount2, amount3)));

            //Console.WriteLine(total.ToString("#,#", CultureInfo.InvariantCulture)); 
            /*Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                                            "{0:#,#}", value));
            Console.WriteLine(total.ToString("C", CultureInfo.CurrentCulture)); // us

            Console.WriteLine(total.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK")));// Swedish
            */
        }
    }
}

/* Task: Create a console app in C# that takes in 3 different dollar amounts. Total up
those amounts, then calculate and print the following to the console:
● The Average
● The Smallest amount
● The Largest amount

Next, format and print the total to look like the proper US format as well as
Japanese, Swedish, and Thai.
So 1923.53 would turn into the following:
● US: $1,923.53
● Swedish: 1 923,53 kr
● Japanese: ￥1,924
● Thai: ฿1,923.53

decimal dec = 123.00M;
string uk = dec.ToString("C", new CultureInfo("en-GB")); // uk holds "£123.00"
string us = dec.ToString("C", new CultureInfo("en-US")); // us holds "$123.00

Build Specifications:
1. Take in 3 numbers using console.readline()
2. Convert those inputs into the double or float data type
3. Calculate the total, average, and the lowest/highest numbers
4. Properly display the total in the following currency formats: US, Swedish,
Japanese, and Thai
5. Only two decimal place should be allowed (or none for Japanese currency).*/
