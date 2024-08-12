using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface IReportsBuilder
	{
		object GenerateReportWithBuilderApproach(int reportType);
		Dictionary<int, string> GenerateBasicFieldsForReports();
		Dictionary<int, string> GenerateFieldsForPreconfiguredReports();
		Dictionary<int, string> GenerateFieldsForCustomReports();

	}
}
