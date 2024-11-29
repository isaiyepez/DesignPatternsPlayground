using Models;
using Models.Enums;
using Services.Contracts;

namespace Services.Services
{
    public class ReportsFactoryAdapterForStrategyClient : IReportsFactoryAdapterForStrategyClient
    {
        public PreconfiguredReport CreatePreconfiguredReportFromFactoryService(int reportType, IReportsGeneratorService reportGeneratorService)
        {
           
            return (PreconfiguredReport)reportGeneratorService
                        .GenerateReportWithFactoryApproach((int)ReportTypeEnums.PreconfiguredReport);
        }
    }
}
