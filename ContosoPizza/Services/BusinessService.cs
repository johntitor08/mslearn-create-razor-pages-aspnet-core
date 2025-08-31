namespace ContosoPizza.Services
{
    public interface IBusinessService
    {
        TimeSpan TimeInBusiness { get; }
        int DaysInBusiness { get; }
    }

    public class BusinessService : IBusinessService
    {
        private static readonly DateTime _startDate = new DateTime(2018, 8, 14);

        public TimeSpan TimeInBusiness => DateTime.Now - _startDate;
        public int DaysInBusiness => (int)TimeInBusiness.TotalDays;
    }
}
