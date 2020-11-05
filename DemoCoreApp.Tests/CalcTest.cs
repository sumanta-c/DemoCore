using System;
using Xunit;
using DemoCoreApp.Models;

namespace DemoCoreApp.Tests
{
    public class CalcTest
    {
        [Fact]
        public void Add_TestTrue()
        {
            calc objcalc = new calc();  
            objcalc.Add(20,10);
            Assert.Equal(30,objcalc.result); 
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(10,10,20)]
        [InlineData(13,14,27)]
        [InlineData(-1,-1,-2)]
        public void Add_TestPass(double op1, double op2, double res)
        {
            calc objcalc = new calc();  
            objcalc.Add(op1,op2);
            Assert.Equal(res,objcalc.result);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(10,10,20)]
        [InlineData(13,14,27)]
        [InlineData(-1,-1,-2)]
        public void Subtract_TestPass(double op1, double op2, double res)
        {
            calc objcalc = new calc();  
            objcalc.Subtract(op1,op2);
            Assert.Equal(res,objcalc.result);
        }

    }
}