using System;

namespace MagicBx
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size;
            do
            {
                Console.Write("Please enter an odd number to Size of Magic box : ");
                Size = int.Parse(Console.ReadLine());
            } while (Size == 0 || Size % 2 == 0);
            
            double N = Math.Pow(Size, 2);
            int row = 1, col= (Size + 1) / 2;
            Console.WriteLine("Row 1 Col {0} = 1 ", col); //NUMBER ONE
            for ( int i=2;i<=N; i++)
            {
                if ((i-1)%Size!=0)
                {
                    if (row - 1 == 0)
                    {
                        row = Size;
                    }
                    else
                    {
                        row = row - 1;
                    }
                    if (col - 1 == 0)
                    {
                        col = Size;
                    }
                    else
                    {
                        col = col - 1;
                    }

                }
                else
                {
                    if (row >= Size)
                    {
                        row = 3;
                    }
                    else
                    {
                        row ++;
                    }
                }
                Console.WriteLine("Row {0} Col {1} = {2} ",row, col,i); //NUMBER #



            }



        }
    }
}
