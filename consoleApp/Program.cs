using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csproj2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index ++;
            } while(index <= 5); 

            Console.WriteLine("Hello World!");

           // Console.WriteLine(getDay(2));
            // fetch num 1
        
            // fetch num 2
            double num2 = Convert.ToDouble( Console.ReadLine());
           // Console.WriteLine(GetMax(14,7,6));

        }

        static string getDay(int dayNum){
            string dayName;

            switch (dayNum) {
                case 1:
                    dayName = "Monday";
                    break; 
                case 2:
                    dayName = "Tuesday";
                    break; 
                case 3:
                    dayName = "Wednesday";
                    break; 
                case 4:
                    dayName = "Thursday";
                    break; 
                case 5:
                    dayName = "Friday";
                    break; 
                case 6:
                    dayName = "Saturday";
                    break; 
                case 7:
                    dayName = "Sunday";
                    break; 
                default: 
                    dayName = "Unknown";
                    break;
            }

            return dayName;
        }
        static int GetMax(int num1, int num2, int num3) {
            int result;

            if (num1 >= num2 && num1 >= num3) {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3) {
                result = num2;
            } else {
                result = num3;
            }
            return result;
        }
        
        static int cube(int num) {
            int result = num * num * num;
            return result;
        }

        static void SayHi(string name) {
            Console.WriteLine("Hello " + name);
        }
    }
}
