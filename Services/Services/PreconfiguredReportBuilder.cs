using Services.Contracts;

namespace Services.Services
{
	public class PreconfiguredReportBuilder : IReportsBuilder
	{
		public int payPlanId { get; set; }
		public int surveySourceId { get; set; }
		public int surveyScopeId { get; set; }

		public List<string> BuildReportFields()
		{
			List<string> fields = new List<string>();

			PayPlanFacadeForMassiveInterface payPlanFacade = new();

			SurveySourceHandler surveySourceHandler = new SurveySourceHandler();

			var payPlanInfo = payPlanFacade
                .GetPayPlan(payPlanId);

			var surveySourceInfo = surveySourceHandler
				.GetSurveySourceInformation(payPlanId, surveySourceId);

			fields.Add(payPlanInfo);
			fields.Add(surveySourceInfo);

			return fields;
		}

		public string BuildReportName()
		{
			return "Preconfigured Report From Builder";
		}
	}
}
