namespace Services.Contracts
{
    public interface ISurveyScopeHandler
	{
		string GetSurveyScopeInformation(int payPlanId, int surveyScopeId);
	}
}
