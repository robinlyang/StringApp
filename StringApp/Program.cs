using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stuff1 = { "aa", "bb" };
            char[] stuff2 = { 'a', 'b' };
            string num1 = "2";
            int x1 = Convert.ToInt32(num1);
            Console.WriteLine(x1);
            char num2 = '1';            //char's are stored as the ASCI code
            int x2 = Convert.ToInt32(num2);
            Console.WriteLine(x2);
            Console.WriteLine(num2);
            x2 = Convert.ToInt32(num2.ToString());
            Console.WriteLine(x2);
            num1 = "1234";
            int total = 0;
            for(int x = 0; x < num1.Length; x++)
            {
                total = total + Convert.ToInt32(num1.Substring(x, 1));
            }
            Console.WriteLine(total);
            char[] num1c = num1.ToCharArray();
            total = 0;
            for(int x = 0; x<num1c.Length; x++)
            {
                total = total + Convert.ToInt32(num1c[x].ToString());
            }
            Console.WriteLine(total);
            string num3 = "12,34,56";
            string[] num3s = num3.Split(',');   //Pull apart
            Console.WriteLine(num3s[0]);
            Console.WriteLine(num3s[1]);
            num3 = string.Join(",", num3s);     //Put back on one line
            string num4 = "1234";
            char[] num4c = num4.ToCharArray();  //Pull apart to char's
            num4 = new string(num4c);           //Put back into a string
            string num5 = "1234";
            byte[] num5b = Encoding.ASCII.GetBytes(num5);   //Pull apart to bytes
            num5 = Encoding.ASCII.GetString(num5b);         //Put back into a string
            Console.WriteLine(num5.GetHashCode());
            num5 = num5 + "5";                          //num5 is reallocated in memory with enough space for 5    
            StringBuilder s = new StringBuilder(20);    //Creates a fix size in memory that doesn't change
            s.Append("1234");
            s.Append("5");
            Console.WriteLine(s);


            Console.ReadLine();
        }
    }
}
