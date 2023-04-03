using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public class Member
    {
        public String id { get; set; }
        public String name { get; set; }
        List<PaymentRequest> paymentRequests;

        public Member(string id, string name)
        {
            this.id = id;
            this.name = name;

            paymentRequests = new List<PaymentRequest>();
        }

        public void FulfilPaymentRequest(PaymentRequest request)
        {
            if (paymentRequests.Contains(request))
            {
                _ = paymentRequests.Remove(request);
            }
        }

        public bool HasOngoingPaymentRequest()
        {
            return (paymentRequests.Count > 0);
        }

        public void AssignPaymentRequest(PaymentRequest request)
        {
            paymentRequests.Add(request);
        }
    }
}
