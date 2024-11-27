namespace Services.Contracts
{
    public interface ISurveySourceHandler
	{
		string GetSurveySourceInformation(int payPlanId, int surveySourceId);
	}
}
