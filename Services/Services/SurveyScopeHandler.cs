using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
	public class SurveyScopeHandler : ISurveyScopeHandler
	{
		public string GetSurveyScopeInformation(int payPlanId, int surveyScopeId)
		{
			return $"Added Info from PayPlan Id {payPlanId} and s. SCOPE {surveyScopeId}";
		}
	}
}
