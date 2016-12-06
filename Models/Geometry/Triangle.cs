using System;

public class Triangle
{
    public int Side1Length { get; set; }
    public int Side2Length { get; set; }
    public int Side3Length { get; set; }

    public Triangle(int side1Length, int side2Length, int side3Length)
    {
        Side1Length = side1Length;
        Side2Length = side2Length;
        Side3Length = side3Length;
    }

    public bool isRealTriangle()
    {
        if((Side1Length + Side2Length) <= Side3Length) return false;
        if((Side2Length + Side3Length) <= Side1Length) return false;
        if((Side1Length + Side3Length) <= Side2Length) return false;
        return true;
    }

    public static bool isRealTriangle(int side1Length, int side2Length, int side3Length)
    {
        if((side1Length + side2Length) <= side3Length) return false;
        if((side2Length + side3Length) <= side1Length) return false;
        if((side1Length + side3Length) <= side2Length) return false;
        return true;
    }

}