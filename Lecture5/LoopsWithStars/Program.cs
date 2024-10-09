using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create 10 stars vertically
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            #endregion

            #region Create 10 stars horizontally
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // To move to the next line after printing stars horizontally
            #endregion 

            #region Create 10 stars vertically with 10 stars in each row
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }
            #endregion

            #region Right-angled triangle
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region Inverted right-angled triangle
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region Rhombus
            int rows = 5; // Height of the rhombus

            // Top part of the rhombus
            for (int i = 1; i <= rows; i++)
            {
                // Spaces
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Bottom part of the rhombus
            for (int i = rows - 1; i >= 1; i--)
            {
                // Spaces
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region Pyramid
            int pyramidHeight = 5; // Height of the pyramid

            for (int i = 1; i <= pyramidHeight; i++)
            {
                // Spaces
                for (int j = i; j < pyramidHeight; j++)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region Inverted Pyramid
            int invertedPyramidHeight = 5; // Height of the inverted pyramid

            for (int i = invertedPyramidHeight; i >= 1; i--)
            {
                // Spaces
                for (int j = invertedPyramidHeight; j > i; j--)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
