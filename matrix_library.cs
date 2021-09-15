using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int row1, colm1, row2, colm2;
            Console.WriteLine("Enter the number of rows and columns of the first matrix");
            row1 = Convert.ToInt32(Console.ReadLine());
            colm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of rows and columns of the  matrix");
            row2 = Convert.ToInt32(Console.ReadLine());
            colm2 = Convert.ToInt32(Console.ReadLine());
            float[,] a = new float[row1, colm1];
            float[,] b = new float[row2, colm2];

            Console.WriteLine("Plz Enter Elements in First Matrice");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < colm1; j++)
                {
                    Console.WriteLine("Plz Enter {0} Column Element of {1} Row", i + 1, j + 1);
                    a[i, j] = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nPlz Enter Elements in Second Matrice");

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < colm2; j++)
                {
                    Console.WriteLine("Plz Enter {0} Column Element of {1} Row", i + 1, j + 1);
                    b[i, j] = float.Parse(Console.ReadLine());
                }
            }


            Matrices M = new Matrices();
            M.ShowMatrices(a, b, row1, colm1, row2, colm2);
            M.ScalarMultiplyMatrices(a, b, row1, colm1, row2, colm2);
            M.ProductMatrices(a, b, row1, colm1, row2, colm2);
            M.AddMatrices(a, b, row1, colm1, row2, colm2);
            M.SubtractMatrices(a, b, row1, colm1, row2, colm2);
            M.TransposeOfMatrices(a, b, row1, colm1, row2, colm2);
        }
    }
    class Matrices
    {
            
        public void ShowMatrices(float[,] a, float[,] b, int row1,int colm1,int row2,int colm2)
        {
            Console.WriteLine("Here are Matrices\n");
            Console.WriteLine("First Matrice\n");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < colm1; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Matrice\n");

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < colm2; j++)
                {
                    Console.Write("{0}\t", b[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void ProductMatrices(float[,] a, float[,] b, int row1, int colm1, int row2, int colm2)
        {

            if (colm1 != row2)
            {
                Console.WriteLine("The product cannot be performed");
            }
            else
            {

                float[,] c = new float[row1, colm2];
                int i, j;
                for (i = 0; i < row1; i++)
                {
                    for (j = 0; j < colm2; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < colm1; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                Console.WriteLine("The product of the two matrices is :");
                for (i = 0; i < row1; i++)
                {
                    for (j = 0; j < colm2; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }


        public void ScalarMultiplyMatrices(float[,] a, float[,] b, int row1, int colm1, int row2, int colm2)
        {
            Console.WriteLine("Enter scalar value: \n");
            float scalar = float.Parse(Console.ReadLine());
            Console.WriteLine("After Scalar Multiplication of 1st Matrice: \n");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < colm1; j++)
                {
                    Console.Write("{0}\t", (a[i, j]) * scalar);
                }
                Console.WriteLine();
            }

            Console.WriteLine("After Scalar Multiplication of 2nd Matrice: \n");

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < colm2; j++)
                {
                    Console.Write("{0}\t", (b[i, j]) * scalar);

                }
                Console.WriteLine();
            }
        }
        public void ProductMatrice(float[,] a, float[,] b, int row1, int colm1, int row2, int colm2)
        {
            Console.WriteLine("Enter scalar value: \n");
            float scalar = float.Parse(Console.ReadLine());
            Console.WriteLine("After Scalar Multiplication of 1st Matrice: \n");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < colm1; j++)
                {
                    Console.Write("{0}\t", (a[i, j]) * scalar);
                }
                Console.WriteLine();
            }

            Console.WriteLine("After Scalar Multiplication of 2nd Matrice: \n");

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < colm2; j++)
                {
                    Console.Write("{0}\t", (b[i, j]) * scalar);
                }
                Console.WriteLine();
            }
        }
        public void AddMatrices(float[,] a, float[,] b, int row1, int colm1, int row2, int colm2)
        {
            if(row1!=row2 && colm1!=colm2)
            {
                Console.WriteLine("Cannot perform addition due to dimension mismatch!");
            }
            else
            {
                Console.WriteLine("After Addition\n");
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < colm1; j++)
                    {
                        Console.Write("{0}\t", a[i, j] + b[i, j]);
                    }
                    Console.WriteLine();
                }

            }
           
        }
        public void SubtractMatrices(float[,] a, float[,] b, int row1, int colm1, int row2, int colm2)
        {
            if (row1 != row2 && colm1 != colm2)
            {
                Console.WriteLine("Cannot perform subtraction due to dimension mismatch!");
            }
            else
            {
                Console.WriteLine("After Subtraction\n");
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < colm1; j++)
                    {
                        Console.Write("{0}\t", a[i, j] - b[i, j]);
                    }
                    Console.WriteLine();
                }

            }
        }
        public void TransposeOfMatrices(float[,] a, float[,] b, int row1, int colm1, int row2, int colm2)
        {
            Console.WriteLine("After Transpose of Both Matrices");
            Console.WriteLine("First Matrice\n");

            for (int i = 0; i < colm1; i++)
            {
                for (int j = 0; j < row1; j++)
                {
                    Console.Write("{0}\t", a[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Matrice\n");

            for (int i = 0; i < colm2; i++)
            {
                for (int j = 0; j < row2; j++)
                {
                    Console.Write("{0}\t", b[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
