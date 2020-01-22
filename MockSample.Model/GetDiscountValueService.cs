namespace MockSample.Model
{
    public class GetDiscountValueService
    {
        private readonly ICustomerrepository customerrepository;

        public GetDiscountValueService(ICustomerrepository customerrepository)
        {
            this.customerrepository = customerrepository;
        }
        public int Execute(int CustomerId)
        {
            var customer = customerrepository.Get(CustomerId);
            switch (customer.CustomerType)
            {
                case CustomerType.Usual:
                    return 1000;
                case CustomerType.Silver:
                    return 5000;
                case CustomerType.Gold:
                    return 10000;
                default:
                    return 0;
            }
        }
    }
}
