namespace Symmetric_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "This app finds transpose and determines if n x n matrix is symmetric";
            string underline = "--------------------------------------------------------------------";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", underline));
            Console.WriteLine("Enter the value of n");
            int row = int.Parse(Console.ReadLine());
            int col = row;
            int[,] matrix;
            int[,] transpose;
            matrix = new int[row, col];
            transpose = new int[col, row];
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter matrix element - row {i}, column {j}: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matrix");
            Console.WriteLine("------");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Transpose");
            Console.WriteLine("---------");
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transpose[i, j] = matrix[j, i];
                    Console.Write(transpose[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Check for symmetry");
            Console.WriteLine("------------------");

            bool isSymmetric = false;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                    isSymmetric = (matrix[i, j] == transpose[i, j]) ? true : false;
                if (!isSymmetric) break;
            }
            if (isSymmetric)
                Console.WriteLine("The matrix is symmetric");
            else 
                Console.WriteLine("The matrix is not symmetric");

            Console.Read();
        }
    }
}