using System
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rounds");
            Console.WriteLine( "Input");
            int n = Convert.ToInt32(Console.ReadLine());
            double cvalue = 0;
            double avalue = 0;
            int[] arr=new int[n];
            
            for (int i = 0; i <n; i++)
            {
                string cha = Console.ReadLine();
                string[] ch = cha.Split(' ');
                string r = Convert.ToString(ch[0]);
                string y = Convert.ToString(ch[1]);
                string g = Convert.ToString(ch[2]);
                
                arr[i]= addstr(r, y, g);
            }
            Console.WriteLine("Output");
            for (int i = 0; i< arr.Length; i++)
            {
                cvalue += arr[i];
                
                     avalue = (cvalue /(i+1));

                     avalue = Math.Round(avalue, 1); 
                Console.WriteLine(arr[i] + " " + avalue);
            } 
        }
        public static int addstr(string r, string y, string g)
        {
            string str = r + y + g;
            int a = Convert.ToInt32(str);
            return a;
        }
       
    }
}
