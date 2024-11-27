using Services.Contracts;

namespace Services.Services
{
    public class PayPlanFacadeForMassiveInterface : IPayPlanFacadeForMassiveInterface
    {
        public string GetPayPlan(int payPlanId)
        {
            MassiveInterfaceImplementation bigServiceForPayPlan = new MassiveInterfaceImplementation();

            var result = bigServiceForPayPlan.GetPayPlan(payPlanId);

            return $"{result} fetched FROM FACADE approach";

        }
    }
}
