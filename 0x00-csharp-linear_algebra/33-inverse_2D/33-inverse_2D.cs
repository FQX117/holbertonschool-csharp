using System;

/// <summary> A class containing a public method called Inverse2D </summary>
class MatrixMath
{
    /// <summary> To find the inverse of a 2d matrix </summary>
    /// <param name="matrix">The first matrix</param>
    /// <returns>inversed matrix, else -1</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] err = { { -1 } };

        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (err);

        double determinant = matrix[0, 0] * matrix[1, 1] - -1 * matrix[0, 1] * -1 * matrix[1, 0];
        if (determinant == 0)
            return (err);
        
        double[,] result = new double[2, 2];

        result[0, 0] = Math.Round(matrix[1, 1] / determinant, 2);
        result[0, 1] = Math.Round(-1 * matrix[0, 1] / determinant, 2);
        result[1, 0] = Math.Round(-1 * matrix[1, 0] / determinant, 2);
        result[1, 1] = Math.Round(matrix[0, 0] / determinant, 2);

        return (result);
    }
}
