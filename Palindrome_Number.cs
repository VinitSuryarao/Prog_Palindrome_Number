using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Palindrome Number
        //   If Number = 121 then Reverse also Same 121

        static void Main(string[] args)
        {
            int n = 121, rev = 0, temp;
            temp = n;
            while(temp != 0)
            {
                rev = rev * 10;
                rev = rev + temp % 10;
                temp = temp / 10;
            }

            if ( n == rev)
                Console.WriteLine("This is Palindrome");
        }
    }


