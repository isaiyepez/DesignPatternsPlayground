using Services.Contracts;

namespace Services.Services
{
	public class CustomReportBuilder : IReportsBuilder
	{
		public int payPlanId { get; set; }
		public int surveySourceId { get; set; }
		public int surveyScopeId { get; set; }

		public List<string> BuildReportFields()
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

		public string BuildReportName()
		{
			return "Custom Report From Builder";
		}
	}
}
