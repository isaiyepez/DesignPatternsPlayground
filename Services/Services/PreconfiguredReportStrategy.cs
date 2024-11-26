using Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PreconfiguredReportStrategy : IReportStrategy
    {
        public object GenerateReport(int payPlanId, int surveySourceId, int surveyScopeId)
        {
            var report = new PreconfiguredReport();

            report.Name = "Preconfigured Report from STRATEGY";
            report.PreconfiguredFields = GenerateReportFields(payPlanId, surveySourceId);

            return report;
        }

        private List<string> GenerateReportFields(int payPlanId, int surveySourceId)
        {
            List<string> fields = new List<string>();
            PayPlanHandler payPlanHandler = new PayPlanHandler();
            SurveySourceHandler surveySourceHandler = new SurveySourceHandler();

            var payPlanInfo = payPlanHandler
                .GetPayPlanInformation(payPlanId);

            var surveySourceInfo = surveySourceHandler
                .GetSurveySourceInformation(payPlanId, surveySourceId);

            fields.Add(payPlanInfo);
            fields.Add(surveySourceInfo);

            return fields;
        }
    }
}
