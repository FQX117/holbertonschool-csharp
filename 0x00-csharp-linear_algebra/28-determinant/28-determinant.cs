using System;

/// <summary> A class containing a public method called Determinant </summary>
class MatrixMath
{
    /// <summary> To find the determinant of a matrix </summary>
    /// <param name="matrix">The first matrix</param>
    /// <returns>determinant, else -1</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (-1);
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return (-1);
        if (matrix.GetLength(0) == 2)
            return (Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2));
        
        double one = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
        double two = matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0];
        double three = matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0];

        return (Math.Round(matrix[0, 0] * one - matrix[0, 1] * two + matrix[0, 2] * three, 2));
    }
}
