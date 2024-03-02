using System;
 class Program
{
static void Main(string[] args)
    {
int rows = 5; // Number of rows in the pattern
for (int i = 0; i< rows; i++)
        {
for (int j = 0; j < rows; j++)
            {
                // Check if the current position is where 1 or 0 should be printed
if (i == j || i + j == rows - 1)
                {
if (i % 2 == 0) // If even row
Console.Write("1 ");
else // If odd row
Console.Write("0 ");
                }
else
                {
Console.Write("  "); // Print spaces for other positions
                }
            }
Console.WriteLine(); // Move to the next line after each row
        }
Console.WriteLine("Created by Abhishek sharma");
Console.WriteLine("MCA-II-A Roll-NO:06");
    }
}
