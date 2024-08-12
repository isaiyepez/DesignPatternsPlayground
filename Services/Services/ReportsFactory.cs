using Models;
using Models.Enums;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
	public class ReportsFactory : IReportsFactory
	{
		public object GenerateReportWithFactoryApproach(int reportType)
		{
			ReportTypeEnums reportTypeValue = (ReportTypeEnums)reportType;

			switch (reportTypeValue)
			{
				case ReportTypeEnums.CustomReport:
					return new CustomReport{
						Name = "Custom Report From Factory"
					};
				case ReportTypeEnums.PreconfiguredReport:
					return new PreconfiguredReport
					{
						Name = "Preconfigured Report From Factory"
					};
				default:
					return new Report{
						Name = "Generic Report From Factory"
					};
			}
		}
	}
}
