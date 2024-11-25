using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
	public class PayPlanHandler : IPayPlanHandler
	{
		public string GetPayPlanInformation(int payPlanId)
		{
			return $"Added Info from PayPlan Id {payPlanId} using HANDLER";

		}
	}
}
