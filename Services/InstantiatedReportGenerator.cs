using Models;

namespace Services
{
	public class InstantiatedReportGenerator
	{
		public CustomReport GenerateCustomReport()
		{
			CustomReport customReport = new CustomReport();

			customReport.Name = "My new custom report";

			return customReport;
		}

		public PreconfiguredReport GeneratePreconfiguredReport()
		{
			PreconfiguredReport preconfiguredReport = new PreconfiguredReport();

			preconfiguredReport.Name = "My new preconfigured report";

			return preconfiguredReport;
		}
	}
}
