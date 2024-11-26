namespace Services.Contracts
{
    public interface IReportStrategy
    {
        object GenerateReport(int payPlanId, int surveySourceId, int surveyScopeId);
    }
}
