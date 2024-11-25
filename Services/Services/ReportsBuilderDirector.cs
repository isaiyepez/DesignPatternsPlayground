using Models;

namespace Services.Services
{
	public class ReportsBuilderDirector
	{
		

		public int _payPlanId { get; set; }
		public int _surveySourceId { get; set; }
		public int _surveyScopeId { get; set; }

		public ReportsBuilderDirector(
			int payPlanId, int surveySourceId, int surveyScopeId)
		{
			
			_payPlanId = payPlanId;
			_surveySourceId = surveySourceId;
			_surveyScopeId = surveyScopeId;
		}
		public CustomReport GenerateCustomReport(CustomReportBuilder customReportBuilder)
		{
			var report = new CustomReport();

			customReportBuilder.payPlanId = _payPlanId;
			customReportBuilder.surveySourceId = _surveySourceId;
			customReportBuilder.surveyScopeId = _surveyScopeId;
			
			report.Name = customReportBuilder.BuildReportName();
			report.CustomFields = customReportBuilder.BuildReportFields();

			return report;

		}
		public PreconfiguredReport GeneratePreconfiguredReport(PreconfiguredReportBuilder preconfiguredReportBuilder)
		{
			var report = new PreconfiguredReport();

			preconfiguredReportBuilder.payPlanId = _payPlanId;
			preconfiguredReportBuilder.surveySourceId= _surveySourceId;
			preconfiguredReportBuilder.surveyScopeId= _surveyScopeId;

			report.Name = preconfiguredReportBuilder.BuildReportName();
			report.PreconfiguredFields = preconfiguredReportBuilder.BuildReportFields();

			return report;

		}
	}
}
