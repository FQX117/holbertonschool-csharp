using System;

/// <summary> A class containing a public method called Shear2D </summary>
class MatrixMath
{
    /// <summary> To find the shear of a matrix </summary>
    /// <param name="matrix">The first matrix</param>
    /// <param name="direction">The direction of shear </param>
    /// <param name="factor">The factor we are scaling by </param>
    /// <returns>matrix that is the result of the shear, else -1</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] err = { { -1 } };

        if (direction != 'x' && direction != 'y')
            return (err);
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (err);

        double [,] sum = new double[2, 2];

        if (direction == 'x')
        {
            sum[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            sum[0, 1] = matrix[0, 1];
            sum[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
            sum[1, 1] = matrix[1, 1];
        }
        else
        {
            sum[0, 0] = matrix[0, 0];
            sum[0, 1] = matrix[0, 0] + factor * matrix[0, 1];
            sum[1, 0] = matrix[1, 0];
            sum[1, 1] = matrix[1, 0] + factor * matrix[1, 1];
        }
        return (sum);
    }
}
