using System;
using Xunit;
using Moq;
namespace MockSample.Model.CustomerTest
{
    public class GetDiscountValueServiceTest
    {
        [Fact]
        public void Should_return1000WhenGetUsual()
        {
            Mock<ICustomerrepository> mock = new Mock<ICustomerrepository>();
            mock.Setup(c => c.Get(It.IsAny<int>())).Returns( new Customer
            {
                CustomerType = CustomerType.Usual
            });
            GetDiscountValueService getDiscount = new GetDiscountValueService(mock.Object);
            var result = getDiscount.Execute(0);
            Assert.Equal(1000, result);


        }
    }
}
