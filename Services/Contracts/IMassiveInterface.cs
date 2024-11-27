namespace Services.Contracts
{
    public interface IMassiveInterface
    {
        string GetPayPlan(int payPlanId);
        string GetSurveyScope(int payPlanId, int surveyScopeId);
        string GetSurveySource(int payPlanId, int surveySourceId);
    }
}
