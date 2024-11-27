using Models;
using Models.Enums;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
