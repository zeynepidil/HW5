using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.Concrete
{
    class SaleManager:ISaleService
    {
        public void Add(Entities.Sale sale, Customer customer,Campaign campaign)
        {

        }
        public void Update(Entities.Sale sale, Customer customer, Campaign campaign)
        {

        }

        public void Delete(Customer customer, Campaign campaign, Entities.Sale sale)
        {

        }
    }

    internal interface ISaleService
    {
    }
}
