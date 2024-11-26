using Models;
using Services.Contracts;

namespace Services.Services
{
    public class CustomReportStrategy : IReportStrategy
    {
        public object GenerateReport(int payPlanId, int surveySourceId, int surveyScopeId)
        {
            var report = new CustomReport();

            report.Name = "Custom Report from STRATEGY";
            report.CustomFields = GenerateReportFields(payPlanId, surveySourceId, surveyScopeId);

            return report;
        }

        private List<string> GenerateReportFields(int payPlanId, int surveySourceId, int surveyScopeId)
        {
            List<string> fields = new List<string>();
            PayPlanHandler payPlanHandler = new();
            SurveySourceHandler surveySourceHandler = new();
            SurveyScopeHandler surveyScopeHandler = new();

            var payPlanInfo = payPlanHandler
                .GetPayPlanInformation(payPlanId);

            var surveySourceInfo = surveySourceHandler
                .GetSurveySourceInformation(payPlanId, surveySourceId);

            var surveyScopeInfo = surveyScopeHandler
                .GetSurveyScopeInformation(payPlanId, surveyScopeId);

            fields.Add(payPlanInfo);
            fields.Add(surveySourceInfo);
            fields.Add(surveyScopeInfo);

            return fields;
        }
    }
}
