using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
	public class SurveySourceHandler : ISurveySourceHandler
	{
		public string GetSurveySourceInformation(int payPlanId, int surveySourceId)
		{
			return $"Added Info from PayPlan Id {payPlanId} and s. SOURCE {surveySourceId}";
		}
	}
}
