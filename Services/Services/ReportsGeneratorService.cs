using Models;
using Services.Contracts;

namespace Services.Services
{
    public class ReportsGeneratorService : IReportsGeneratorService
    {
        private readonly IReportsFactory _reportsFactory;

        public ReportsGeneratorService(IReportsFactory reportsFactory)
        {
            _reportsFactory = reportsFactory;
        }

        public object GenerateReportWithFactoryApproach(int reportType)
        {
            return _reportsFactory.GenerateReportWithFactoryApproach(reportType);
        }
    }
}
