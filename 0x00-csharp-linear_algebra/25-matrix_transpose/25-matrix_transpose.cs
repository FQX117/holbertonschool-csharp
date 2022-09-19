using System;

/// <summary> A class containing a public method called Transpose </summary>
class MatrixMath
{
    /// <summary> To find the transposed matrix </summary>
    /// <param name="matrix">The first matrix</param>
    /// <returns>resulting matrix, else empty matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = {};

        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (result);
        
        result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                result[j, i] = matrix[i, j];
        
        return (result);
    }
}
