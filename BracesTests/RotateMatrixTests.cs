using CodeWars;
using Xunit;

namespace BracesTests
{
    public class RotateMatrixTests
    {
        [Fact]
        public void Rotate()
        {
            var oldMatrix = new[,]
           {{-1,4,3,4},
             {5,6,7,8},
             {2,5,1,7},
             {3,14,-5,3}};
            var newMatrix = new[,]
            {{4,8,7,3},
             {3,7,1,-5},
             {4,6,5,14},
             {-1,5,2,3}};
            Assert.Equal(newMatrix, RotateMatrix.RotateMatrixLeft(oldMatrix));

            int[,] oldMatrix1 = new int[2, 4]
           {{-1,4,3,4},
             {5,6,7,8}};
            int[,] newMatrix1 = new int[4, 2]
            {{4,8},
             {3,7},
             {4,6},
             {-1,5}};
            Assert.Equal(newMatrix1, RotateMatrix.RotateMatrixLeft(oldMatrix1));
        }
    }
}
