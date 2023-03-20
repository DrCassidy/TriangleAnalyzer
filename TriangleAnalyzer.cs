using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAnalyzer
{
    public class TriangleAnalyzer
    {
        //returns true if the sides evaluate to a valid triangle
        public bool IsTriangle(int a, int b, int c){
            if ((a + b) > c && (b + c) > a && (c + a) > b)
                return true;
            else
                return false;
        }

        //Returns the type of triangle
        public string ClassifyTriangle(int a, int b, int c){
            if ((a == b && b == c) && IsTriangle(a,b,c))
                return "equilateral";
            else if ((a == b || a == c || b == c ) && IsTriangle(a, b, c))
                return "isosceles";
            else if (IsTriangle(a, b, c))
                return "scalene";
            else
                return "not a triangle";
        }
    }
}


