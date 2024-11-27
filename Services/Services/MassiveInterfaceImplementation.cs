using Services.Contracts;

namespace Services.Services
{
    public class MassiveInterfaceImplementation : IMassiveInterface
    {
        public string GetPayPlan(int payPlanId)
        {
            PayPlanHandler payPlanHandler = new();
           
            return payPlanHandler
                .GetPayPlanInformation(payPlanId);
        }

        public string GetSurveyScope(int payPlanId, int surveyScopeId)
        {
            SurveyScopeHandler surveyScopeHandler = new();
            return surveyScopeHandler
                .GetSurveyScopeInformation(payPlanId, surveyScopeId);
        }

        public string GetSurveySource(int payPlanId, int surveySourceId)
        {
            SurveySourceHandler surveySourceHandler = new();

            return surveySourceHandler
                .GetSurveySourceInformation(payPlanId, surveySourceId);
        }
    }
}
