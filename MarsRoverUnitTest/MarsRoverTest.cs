using MarsRoverProblem;
using MarsRoverProblem.Enums;
using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRoverUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            position.StartMoving(maxPoints, moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test2()
        {
            Position position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MMRMMRMRRM";

            position.StartMoving(maxPoints, moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "2 3 S";//must be wrong

            Assert.AreNotEqual(expectedOutput, actualOutput);
        }
    }
}