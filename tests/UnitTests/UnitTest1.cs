using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void DivisionOFTwoNumbers()
         {
      var expected =  2;
            var a= 10;
            var b= 5;
            var result = Division(a,b);
            Assert.Equal(expected, result);

        }
       [Theory]
       [InlineData(10,100,10)]
       [InlineData(1,1,1)]
       [InlineData(18,180,10)]
       public void DivisionOFTwo_Numbers(int res, int n1, int n2)
            {
            Assert.Equal(res, Division(n1, n2));
}
            
        int Division(int x, int y)   
{
            return x / y; 
}

    }
}
