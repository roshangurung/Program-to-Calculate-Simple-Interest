using System;
namespace Interest
{
    class Program///In this C# program, library function defined in
///////////////header file is used.We are reading the loan amount, the number of years, and the rate of interest using ‘princamt’, ‘year’ and ‘rate’ variables respectively.To compute the simple interest following formula is used.

/////////////Simple Interest = princamt * rate * year / 100
    {
        static void Main(string[] args)
        {
            int year;
            double princamt, rate, interest, total_amt;
            Console.Write("Enter The Loan Amount : ");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;
            total_amt = princamt + interest;
            Console.WriteLine("Total Amount : {0}", total_amt);
            Console.ReadLine();
        }
    }
}
///Output:
///Enter the Loan Amount : 1000
///Enter the Number of Years : 3
///Enter the Rate of Interest : 2
///Total Amount : 1060