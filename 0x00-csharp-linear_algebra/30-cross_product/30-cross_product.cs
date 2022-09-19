using System;

/// <summary> A class containing a public method called CrossProduct </summary>
class VectorMath
{
    /// <summary> To find the cross product of two vectors </summary>
    /// <param name="vector1">The first vector</param>
    /// <param name="vector2">The second vector</param>
    /// <returns>cross product, else -1</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] err = { -1 };

        if (vector1.GetLength(0) != 3 || vector2.GetLength(0) != 3)
            return (err);

        return new double[3] {vector1[1] * vector2[2] - vector1[2] * vector2[1], vector1[2] * vector2[0] - vector1[0] * vector2[2], vector1[0] * vector2[1] - vector1[1] * vector2[0]};
    }
}
