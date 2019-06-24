using System;
using System.Globalization;

namespace Deliverable1KNCurrencyFormatConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double amount1, amount2, amount3;
            //declare variables

            Console.Write("Enter the First dollar amount: ");
            amount1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second dollar amount: ");
            amount2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Third dollar amount: ");
            amount3 = Convert.ToDouble(Console.ReadLine());
            //accept amount inputs

            double result = (amount1 + amount2 + amount3) / 3;
            Console.WriteLine("The Average is: ${0} ",
         result);
            //output average of three user inputs

            Console.WriteLine("The Smallest amount: $" + Math.Min(amount1, Math.Min(amount2, amount3)));
            Console.WriteLine("The Largest amount: $" + Math.Max(amount1, Math.Max(amount2, amount3)));
            //output max and min

		double total = amount1 + amount2 + amount3;


			Console.WriteLine("US: {0:C2} ", total);


            CultureInfo sv = new CultureInfo("sv-SE");
			Console.Out.WriteLine("Swedish: {0:C2}", total.ToString("C", sv));

			CultureInfo jp = new CultureInfo("ja-JP");
			Console.Out.WriteLine("Japanese: {0} ", total.ToString("C", jp));

			CultureInfo th = new CultureInfo("th-TH");
			Console.Out.WriteLine("Thai: {0:C2}", total.ToString("c", th));
            //output currencies using (C)

			Console.ReadKey();
			
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

Build Specifications:
1. Take in 3 numbers using console.readline()
2. Convert those inputs into the double or float data type
3. Calculate the total, average, and the lowest/highest numbers
4. Properly display the total in the following currency formats: US, Swedish,
Japanese, and Thai
5. Only two decimal place should be allowed (or none for Japanese currency).*/
