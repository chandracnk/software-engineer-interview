using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Zip.InstallmentsService
{
    /// <summary>
    /// This class is responsible for building the PaymentPlan according to the Zip product definition.
    /// </summary>
    public class PaymentPlanFactory
    {
        /// <summary>
        /// Builds the PaymentPlan instance.
        /// </summary>
        /// <param name="purchaseAmount">The total amount for the purchase that the customer is making.</param>
        /// <returns>The PaymentPlan created with all properties set.</returns>
        public PaymentPlan CreatePaymentPlan(decimal purchaseAmount)
        {
            Installment insObj = new Installment();
            var inscount = 4;
            insObj.Amount = purchaseAmount / inscount;
            insObj.DueDate = System.DateTime.Now;
            List<Installment> insList = new List<Installment>();
            
            PaymentPlan pp = new PaymentPlan();

            for (int i = 0; i < inscount;  i++)
            {                
                    insObj.DueDate.AddDays(i*14);                
                
            }
            
            
            return pp;
        }
    }
}
