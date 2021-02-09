using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.Abstract
{
    interface ISaleService
    {
        void AddSale(Customer customer, Entities.Sale sale,Campaign campaign)
        {

        }
        void UpdateSale(Entities.Sale sale, Customer customer, Campaign campaign)
        {

        }

        void DeleteSale(Customer customer, Entities.Sale sale, Campaign campaign)
        {

        }

    }

}
