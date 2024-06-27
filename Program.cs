/*using System;
namespace App{
    class Addition{
        static void Main(){
            Console.WriteLine("Enter the first number:");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b =int.Parse(Console.ReadLine());
            int c = a+b;
            Console.WriteLine("Addition of number:"+c);  
        }
    }
}*/
/*
using System;

class Program
{
    static void Main()
    {
        // Example  of Boxing
        int valueType = 123;      // Value type
        object boxedValue = valueType;  // Boxing: Converting value type to object type

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

        // Example of Unboxing
        object obj = 456;         // Boxed value
        int unboxedValue = (int)obj; // Unboxing: Converting object type back to value type

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

        // Another example with double
        double doubleValue = 78.9; // Value type
        object boxedDouble = doubleValue; // Boxing

        Console.WriteLine("\nBoxing double:");
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Boxed double: " + boxedDouble);

        double unboxedDouble = (double)boxedDouble; // Unboxing

        Console.WriteLine("\nUnboxing double:");
        Console.WriteLine("Object type: " + boxedDouble);
        Console.WriteLine("Unboxed double: " + unboxedDouble);
    }
}*/

// ASSIGNMENT OPRATOR
/*using System;
namespace Assignment {
    
class GFG {
    
    // Main Function
    static void Main(string[] args)
    {
        
            // initialize variable x
            // using Simple Assignment 
            // Operator "="
            int x = 15; 
            
            // it means x = x + 10
            x += 10; 
            Console.WriteLine("Add Assignment Operator: " + x);
            
             // initialize variable x again
            x = 20;
            
            // it means x = x - 5
            x -= 5; 
            Console.WriteLine("Subtract Assignment Operator: " + x);
            
            // initialize variable x again
            x = 15;
            
            // it means x = x * 5
            x *= 5; 
            Console.WriteLine("Multiply Assignment Operator: " + x);
            
            // initialize variable x again
            x = 25;
            
            // it means x = x / 5
            x /= 5; 
            Console.WriteLine("Division Assignment Operator: " + x);
            
            // initialize variable x again
            x = 25;
            
            // it means x = x % 5
            x %= 5; 
            Console.WriteLine("Modulo Assignment Operator: " + x);
            
            // initialize variable x again
            x = 8;
            
            // it means x = x << 2
            x <<= 2; 
            Console.WriteLine("Left Shift Assignment Operator: " + x);
            
            // initialize variable x again
            x = 8;
            
            // it means x = x >> 2
            x >>= 2; 
            Console.WriteLine("Right Shift Assignment Operator: " + x);
            
            // initialize variable x again
            x = 12;
            
            // it means x = x >> 4
            x &= 4; 
            Console.WriteLine("Bitwise AND Assignment Operator: " + x);
            
            // initialize variable x again
            x = 12;
            
            // it means x = x >> 4
            x ^= 4; 
            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);
            
             // initialize variable x again
            x = 12;
            
            // it means x = x >> 4
            x |= 4; 
            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);
        
    }
}
}*/

// boxing and unboxing

/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int num=12;
        object n1 = num;
        object o ="Sak";
        string a= Convert.ToString(o);
        
    
        Console.WriteLine(num);
        Console.WriteLine(a);
       
    }
}*/

// prime number
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        PrintPrimeNumbersUpToN(n);
    }

    static void PrintPrimeNumbersUpToN(int n)
    {
        bool[] prime = new bool[n + 1];
        for (int i = 0; i <= n; i++)
            prime[i] = true;

        for (int p = 2; p * p <= n; p++)
        {
            if (prime[p] == true)
            {
                for (int i = p * p; i <= n; i += p)
                    prime[i] = false;       
            }
        }
        for (int p = 2; p <= n; p++)
        {
            if (prime[p] == true)
                Console.WriteLine(p);
        }
    }
}
*/
// swap without using third variable
 /* 
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Swapping without using a third variable
        a = a + b; 
        b = a - b; 
        a = a - b; 

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}
*/

// Factorial
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        // Calculate factorial
        long factorial = CalculateFactorial(n);

        // Output the result
        Console.WriteLine($"Factorial of {n} is: {factorial}");
    }

    static long CalculateFactorial(int n)
    {
        // Base case: factorial of 0 is 1
        if (n == 0)
            return 1;

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * i
            ;
        }
        return result;
    }
}
*/
// fibnoci sries
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci series:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci series:");
        // Print Fibonacci series up to n terms
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    // Function to calculate the nth Fibonacci number
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        
        int fib = 0;
        int prev1 = 0;
        int prev2 = 1;
        
        for (int i = 2; i <= n; i++)
        {
            fib = prev1 + prev2;
            prev1 = prev2;
            prev2 = fib;
        }
        
        return fib;
    }
}
*/
// Satr Pattern 
/*
public class Program
{

    public static void Main()
    {
        int number, i, k, count = 1;
        Console.Write("Enter number of rows\n");
        number = int.Parse(Console.ReadLine());
        count = number - 1;
        for (k = 1; k <= number; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * k - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (k = 1; k <= number - 1; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (number - k) - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}*/
/*
public class Program
{
    public static void Main(string[] args)
    {
        int val = 4;
        int i, j, k;
        for (i = 1; i <= val; i++)
        {
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
class Program
{
    static void Main(string[] args)
    {        
    	int val = 8;
        int i, j, k;
        for (i = 1; i <= val; i++)
        {
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}*/
/*
using System;
class Program
{
    static void Main()
    {
        int n = 7;
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 *i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}*/

/*
class Program{
    static void Main(string[] args){
        int n = 6;
        for (int i = n - 1; i >= 1; i--)
        {
             for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }
           
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}
/*
using System;

class Program
{
    static void Main()
    {
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}*/ 
/*
using System;
class Program{
    static void Main()
    {
        Console.WriteLine("Enter the base of the triangle: ");
        double basea = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle: ");

        double height = Convert.ToDouble(Console.ReadLine());
        double area = 0.5 * basea * height;

        Console.WriteLine($"Area of Triangle is:{area}");

    }
}*/

// Area Of Rectangle
/*
using System;
class Program{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of rectangle: ");
        double len = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the breadth of rectangle: ");

        double bre = Convert.ToDouble(Console.ReadLine());
        double area =  len * bre;


        Console.WriteLine($"Area of Rectangle is:{area}");

    }
}
*/
// time and date
/*using System;


class Program
{
    static void Main()
    {
        DateTime localDateTime = DateTime.Now;
        Console.WriteLine("Local Date and Time: " + localDateTime.ToString());

    }
}*/

//Area of Ploygoan 
/*
using System;

class opration
{
    static void Main()
    {
        Console.WriteLine("Enter the number of Sides of Ploygoan ");
        int side = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the lenght of Polygoan: ");

        double len = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the radius of Polygoan: ");

        double radius = Convert.ToDouble(Console.ReadLine());

        double area =  (side / 2) * len * radius;


        Console.WriteLine($"Area of Rectangle is:{area}");

    }
}
*/

// TO PRINT STUDENT RECORD
/*
using System;

class Program
{
    static void Main()
    {
        // Ask the user for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Arrays to store student details
        string[] names = new string[numberOfStudents];
        string[] rolls = new string[numberOfStudents];
        string[] branches = new string[numberOfStudents];
        string[] colleges = new string[numberOfStudents];
        int[] semesters = new int[numberOfStudents];

        // Loop to get student details
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter details for student {i + 1}:");

            Console.Write("Enter name: ");
            names[i] = Console.ReadLine();

            Console.Write("Enter roll number: ");
            rolls[i] = Console.ReadLine();

            Console.Write("Enter branch: ");
            branches[i] = Console.ReadLine();

            Console.Write("Enter college: ");
            colleges[i] = Console.ReadLine();

            Console.Write("Enter semester: ");
            semesters[i] = int.Parse(Console.ReadLine());
        }

        // Print the student records
        Console.WriteLine("\nStudent Records:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Name: {names[i]}, Roll Number: {rolls[i]}, Branch: {branches[i]}, College: {colleges[i]}, Semester: {semesters[i]}");
        }
    }
}
*/


// ATM Machine
/*
using System;
class studentP
{
    static void Main()
    {
        Console.Write("\t\t\tWelcome to ATM Services::\n");
        double balance = 1000; // Initial balance

        Console.Write(" Please Be Careful While Entering The Pincode\n  Enter your PinCde :");
        int pin= int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");   
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Current Balance: ${balance}");
                    break;
                case 2:
                    Console.Write("Enter deposit amount: $");
                    double depositAmount = double.Parse(Console.ReadLine());
                    balance= balance + depositAmount ;
                    Console.WriteLine($"Deposited ${depositAmount}. New Blanced is:: ${balance}");
                    break;
                case 3:
                    Console.Write("Enter withdrawal amount: $");
                    double withdrawalAmount = double.Parse(Console.ReadLine());
                    if (balance >= withdrawalAmount)
                    {
                        balance = balance - withdrawalAmount;
                        Console.WriteLine($"Withdrawn ${withdrawalAmount}. New balance: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Less Amount Present ");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the ATM.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

*/

//Addition of the matrix
/*
using System;
class MatrixAddition{
    static void Main()
    {
        int rows, columns;

        Console.Write("Enter the number of rows in the matrices: ");
        rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns in the matrices: ");
        columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[rows, columns];
        int[,] matrix2 = new int[rows, columns];
        int[,] resultMatrix = new int[rows, columns];

        Console.WriteLine("Enter the elements of the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the elements of the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)

            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Perform matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
         // Perform matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
         // Perform matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }
         // Perform matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] / matrix2[i, j];
            }
        }
         // Perform matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] % matrix2[i, j];
            }
        }

        // Display the result
        Console.WriteLine("The result of matrix addition is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}*/

//Reverse of array
/*
using System;

class ReverseArray
{
    static void Main()
    {
        // Read the number of elements in the array
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // Read the elements of the array from the user
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Reverse the array
        Reverse(array);

        // Display the reversed array
        Console.WriteLine("The reversed array is:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Reverse(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            start++;
            end--;
        }
    }
}
*/
//Matrix opration
/*
using System;

class MatrixOperations
{
    static void Main()
    {
        Console.Write("Enter the number of rows in the matrices: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns in the matrices: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[rows, columns];
        int[,] matrix2 = new int[rows, columns];

        Console.WriteLine("Enter the elements of the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the elements of the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[,] resultMatrix;

        Console.WriteLine("Choose an operation: + - * /");
        char operation = Console.ReadLine()[0];

        switch (operation)
        {
            case '+':
                resultMatrix = AddMatrices(matrix1, matrix2);
                break;
            case '-':
                resultMatrix = SubtractMatrices(matrix1, matrix2);
                break;
            case '*':
                resultMatrix = MultiplyMatrices(matrix1, matrix2);
                break;
            case '/':
                resultMatrix = DivideMatrices(matrix1, matrix2);
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine("The result of the matrix operation is:");
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] DivideMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix2[i, j] != 0)
                {
                    result[i, j] = matrix1[i, j] / matrix2[i, j];
                }
                else
                {
                    Console.WriteLine($"Division by zero encountered at element [{i},{j}]. Setting result to 0.");
                    result[i, j] = 0;
                }
            }
        }
        return result;
    }
}
*/
// TRANSPOSE OF MATRIX
/*
using System;

class Program
{
    static void Main()
    {
        // Define the original matrix
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Get the dimensions of the matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix for the transpose
        int[,] transpose = new int[cols, rows];

        // Perform the transpose
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        // Print the original matrix
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix, rows, cols);

        // Print the transposed matrix
        Console.WriteLine("\nTransposed Matrix:");
        PrintMatrix(transpose, cols, rows);
    }

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/
/*
//INTERCHNAGE THE COLUMNS OF THE MATRIX
using System;

class Program
{
    static void Main()
    {
        // Define the original matrix
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Print the original matrix
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Interchange the first and last columns
        InterchangeColumns(matrix, 0, 3);

        // Print the matrix after interchanging columns
        Console.WriteLine("\nMatrix After Interchanging Columns:");
        PrintMatrix(matrix);
    }

    static void InterchangeColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);
        
        for (int i = 0; i < rows; i++)
        {
            // Swap the elements in col1 and col2
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/
// interchange the row of the matrix
/*
using System;

class Program
{
    static void Main()
    {
        // Define the original matrix
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Print the original matrix
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Interchange the first and last rows
        InterchangeRows(matrix, 0, 2);

        // Print the matrix after interchanging rows
        Console.WriteLine("\nMatrix After Interchanging Rows:");
        PrintMatrix(matrix);
    }

    static void InterchangeRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);
        
        for (int j = 0; j < cols; j++)
        {
            // Swap the elements in row1 and row2
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/
    // program for concatenation of the string
  /*
    using System;

class Program
{
    static void Main()
    {
        // Define two strings
        string str1 = "Hello";
        string str2 = "World";

        // Concatenate the strings
        string result = ConcatenateStrings(str1, str2);

        // Print the result
        Console.WriteLine("Concatenated String: " + result);
    }

    static string ConcatenateStrings(string s1, string s2)
    {
        return s1 + " " + s2;
    }
}
*/
// program for sorting the elements
/*
using System;

class Program
{
    static void Main()
    {
        // Define an array of integers
        int[] numbers = { 5, 2, 9, 1, 5, 6 };

        // Print the original array
        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        // Sort the array
        Array.Sort(numbers);

        // Print the sorted array
        Console.WriteLine("\nSorted Array:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
*/
// program to find the element inside the array
/*
using System;

class Program
{
    static void Main()
    {
        // Define an array of integers
        int[] numbers = { 5, 2, 9, 1, 5, 6 };

        // Element to search for
        int elementToFind = 5;

        // Search for the element
        int index = SearchElement(numbers, elementToFind);

        // Print the result
        if (index != -1)
        {
            Console.WriteLine($"Element {elementToFind} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Element {elementToFind} not found in the array.");
        }
    }

    static int SearchElement(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                return i; // Return the index of the element
            }
        }
        return -1; // Return -1 if the element is not found
    }
}
*/
//inheritance program 
using System;

// Base class
class Vehicle
{
    // Method
    public void Drive()
    {
        Console.WriteLine("Vehicle is being driven.");
    }

    // Virtual method
    public virtual void StartEngine()
    {
        Console.WriteLine("Starting the vehicle engine.");
    }
}

// Derived class Car
class Car : Vehicle
{
    // Override method
    public override void StartEngine()
    {
        Console.WriteLine("Starting the car engine.");
    }
}

// Derived class Motorcycle
class Motorcycle : Vehicle
{
    // Override method
    public override void StartEngine()
    {
        Console.WriteLine("Starting the motorcycle engine.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Car and Motorcycle
        Car myCar = new Car();
        Motorcycle myMotorcycle = new Motorcycle();

        // Call methods
        myCar.StartEngine();
        myMotorcycle.StartEngine();
    }
}
