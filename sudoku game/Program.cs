using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr = new int[9,9];
            for (int i = 0; i < 9; i++)
            {
                string s = Console.ReadLine();
                string[] s1 = s.Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    
                    int a = Convert.ToInt32(s1[j]);
                    if (a > 0 && a < 10)
                    {
                        arr[i, j] = a;
                    }
                    else
                    {
                        System.Console.WriteLine(" please enter 1 to 9 values");
                    }
                }
                
                Console.WriteLine();
            }
            Console.WriteLine(rowcheck(arr));
            Console.WriteLine(colcheck(arr));
            for (int k = 1; k <= 9; k++)
            {

                sub_grid_number(k, arr);
            }
            
        }
        public static bool rowcheck(int[,] arr)
        {
            bool row_flag = true;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                List<int> ls = new List<int>();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        if (!ls.Contains(arr[i, j]))
                        {
                            ls.Add(arr[i,j]);
                        }
                        else
                        {
                            row_flag = false;
                           
                        }
                }
                if (row_flag == false)
                {
                    break;
                }
            }
            return row_flag;
        }
        public static bool colcheck(int[,] arr)
        {
            bool col_flag = true;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                List<int> ls = new List<int>();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (!ls.Contains(arr[j, i]))
                    {
                        ls.Add(arr[j, i]);
                    }
                    else
                    {
                        col_flag = false;
                    }
                }
                if (col_flag == false)
                {
                    break;
                }
            }
            return col_flag;
        }
        public static bool subgridcheck(int x, int y, int[,] arr)
        {
            bool flag=true;
            List<int> ls = new List<int>();
            for (int i = x; i <=x+2; i++)
            {
               
                for (int j = y; j <= y+ 2; j++)
                {
                    if (!ls.Contains(arr[i,j]))
                    {
                        ls.Add(arr[i,j]);
                    }
                    else
                    {
                        flag=false;
                        break;
                    }
                    
                }
                if (flag == false)
                {
                    break;
                }
            }
            return flag;
        }
        public static void sub_grid_number(int x, int[,] arr)
        {
            if (x == 1)
            {
                Console.WriteLine("Sub grid " + x + " " + subgridcheck(0, 0, arr));
            }
            else if (x == 2)
            {
                Console.WriteLine("Sub grid " + x + " " +subgridcheck(0, 3, arr));
            }
            else if (x == 3)
            {
                Console.WriteLine("Sub grid " + x + " " +subgridcheck(0, 6, arr));
            }
            else if (x == 4)
            {
              Console.WriteLine("Sub grid " + x + " " +  subgridcheck(3, 0, arr));
            }
            else if (x == 5)
            {
              Console.WriteLine("Sub grid " + x + " " +  subgridcheck(3, 3, arr));
            }
            else if (x == 6)
            {
               Console.WriteLine("Sub grid " + x + " " + subgridcheck(3, 6, arr));
            }
            else if (x == 7)
            {
              Console.WriteLine("Sub grid " + x + " " +  subgridcheck(6, 0, arr));
            }
            else if (x == 8)
            {
               Console.WriteLine("Sub grid " + x + " " + subgridcheck(6, 3, arr));
            }
            else if (x == 9)
            {
               Console.WriteLine("Sub grid " + x + " " + subgridcheck(6, 6, arr));
            }
        }
        }
    }
