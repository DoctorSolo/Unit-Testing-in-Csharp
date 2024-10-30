using UnitTexting.CalculateYield;
using Xunit;

namespace UnitTexting.TestCalculator
{
    public class UnitTest1
    {

        //Test The Rate Calculatio
        public static IEnumerable<object[]> CorrectRates => new List<object[]>
        {
            new object[] { 
                0.95M, new decimal[] {
                    0.95M, 1.90M, 2.85M, 3.80M, 4.75M, 5.70M, 6.65M, 7.60M, 8.55M, 9.50M, 10.45M, 11.40M
                }
            }, new object[] { 
                1.00M, new decimal[] { 
                    1.00M, 2.00M, 3.00M, 4.00M, 5.00M, 6.00M, 7.00M, 8.00M, 9.00M, 10.00M, 11.00M, 12.00M 
                } 
            }
        };


        [Theory]
        [MemberData(nameof(CorrectRates))]
        public void CalculatesRateText(decimal Rate, decimal[] ExpectedReturn)
        {
            //Act
            decimal[] RateInTwelveMonths = Calculate.CalculatesRateInTwelveMonths(Rate);

            //Assert
            Assert.Equal(ExpectedReturn, RateInTwelveMonths);
        }
    
        [Theory]
        [InlineData(100000, 0.11, 12, 132000)]
        [InlineData(100000, 0.13, 12, 156000)]
        public void CalculateSinpleInterestTest(decimal CashValue, decimal Rate, sbyte T, decimal Expectative)
        {
            //Act
            decimal J = Calculate.CalculatesSimpleInterest(CashValue, Rate, T);

            //Assert
            Assert.Equal(Expectative, J);
        }
    
        
        [Theory]
        [InlineData(100000, 0.11, 12, 249845.06)]
        public void CalculateCompoundInterestTest(decimal CashValue, decimal Rate, sbyte T, decimal Expectative)
        {
            //Act
            decimal JC = Calculate.CalculatesCompoundInterest(CashValue, Rate, T);

            //Assert
            Assert.Equal(Expectative, JC);
        }
    
    
    }
}