using Models.Enums;
using Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
	internal class ReportsBuilder : IReportsBuilder
	{
		public object GenerateReportWithBuilderApproach(int reportType)
		{
			ReportTypeEnums reportTypeValue = (ReportTypeEnums)reportType;
			var basicContent = GenerateBasicFieldsForReports();
			var customizedContent = GenerateFieldsForCustomReports();
			var preconfiguredContent = GenerateFieldsForPreconfiguredReports();

			switch (reportTypeValue)
			{
				case ReportTypeEnums.CustomReport:
					return new CustomReport
					{
						Name = "Custom Report From Factory",
					};
				case ReportTypeEnums.PreconfiguredReport:
					return new PreconfiguredReport
					{
						Name = "Preconfigured Report From Factory"
					};
				default:
					return new Report
					{
						Name = "Generic Report From Factory"
					};
			}
		}
		public Dictionary<int, string> GenerateBasicFieldsForReports()
		{
			throw new NotImplementedException();
		}

		public Dictionary<int, string> GenerateFieldsForCustomReports()
		{
			throw new NotImplementedException();
		}

		public Dictionary<int, string> GenerateFieldsForPreconfiguredReports()
		{
			throw new NotImplementedException();
		}
	}
}
