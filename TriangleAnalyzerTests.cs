using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAnalyzer
{
    [TestFixture]
    class TriangleAnalyzerTests
    {
        [TestCase(3,3,3)]
        [TestCase(2,4,5)]
        [TestCase(5,4,2)]
        [TestCase(4,4,1)]
        public void IsTriangle_ValidSides_ReturnsTrue(int a, int b, int c){
            //Arrange
            TriangleAnalyzer ta = new TriangleAnalyzer();
            //Act
            bool isValid = ta.IsTriangle(a, b, c);
            //Assert
            Assert.IsTrue(isValid);
        }

        [TestCase(2,2,5)]
        [TestCase(5,9,3)]
        [TestCase(10,4,4)]
        [TestCase(4, 4, 0)]
        [TestCase(4, 0, 0)]
        [TestCase(0, 0, 0)]
        public void IsTriangle_InvalidSides_ReturnsFalse(int a, int b, int c){
            //Arrange
            TriangleAnalyzer ta = new TriangleAnalyzer();
            //Act
            bool isValid = ta.IsTriangle(a, b, c);
            //Assert
            Assert.IsFalse(isValid);
        }

        [TestCase(3,3,3)]
        [TestCase(10, 10, 10)]
        [TestCase(5, 5, 5)]
        [TestCase(7, 7, 7)]
        public void ClassifyTriangle_EqualSides_ReturnsEquilateral(int a, int b, int c){
            //Arrange
            TriangleAnalyzer ta = new TriangleAnalyzer();
            //Act 
            string result = ta.ClassifyTriangle(a, b, c);
            //Assert
            Assert.AreEqual(result, "equilateral");
        }

        [TestCase(3, 3, 5)]
        [TestCase(10, 10, 5)]
        [TestCase(7, 5, 5)]
        [TestCase(7, 7, 1)]
        public void ClassifyTriangle_2EqualSides_ReturnsIsoceles(int a, int b, int c){
            //Arrange
            TriangleAnalyzer ta = new TriangleAnalyzer();
            //Act 
            string result = ta.ClassifyTriangle(a, b, c);
            //Assert
            Assert.AreEqual(result, "isosceles");
        }

        [TestCase(3, 4, 5)]
        [TestCase(10, 8, 5)]
        [TestCase(7, 3, 5)]
        [TestCase(7, 9, 3)]
        public void ClassifyTriangle_NoEqualSides_ReturnsScalene(int a, int b, int c){
            //Arrange
            TriangleAnalyzer ta = new TriangleAnalyzer();
            //Act 
            string result = ta.ClassifyTriangle(a, b, c);
            //Assert
            Assert.AreEqual(result, "scalene");
        }

        [TestCase(2, 2, 5)]
        [TestCase(5, 9, 3)]
        [TestCase(10, 4, 4)]
        [TestCase(4, 4, 0)]
        [TestCase(4, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(0, -3, -3)]
        [TestCase(0, 1, 2)]
        public void ClassifyTriangle_InvalidTriangle_ReturnsNotATri(int a, int b, int c){
            //Arrange
            TriangleAnalyzer ta = new TriangleAnalyzer();
            //Act 
            string result = ta.ClassifyTriangle(a, b, c);
            //Assert
            Assert.AreEqual("not a triangle", result);
        }
    }
}
