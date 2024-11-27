namespace Services.Contracts
{
    public interface IReportsBuilder
	{
		int payPlanId { get; set; }
		int surveySourceId { get; set; }
		int surveyScopeId { get; set; }
		string BuildReportName();
		List<string> BuildReportFields();

	}
}
