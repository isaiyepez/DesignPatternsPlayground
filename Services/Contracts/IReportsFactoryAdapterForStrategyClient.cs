using Models;

namespace Services.Contracts
{
    public interface IReportsFactoryAdapterForStrategyClient
    {
        PreconfiguredReport CreatePreconfiguredReportFromFactoryService(int reportType, IReportsGeneratorService reportGeneratorService);
    }
}
