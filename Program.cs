using HW5.Concrete;
using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            

                Customer customer1 = new Customer() { FirstName = "İdil", LastName = "Erkal", YearofBirth = 1999, IdentityNumber = 123 };
                Customer customer2 = new Customer() { FirstName = "İrem", LastName = "Erkal", YearofBirth = 1991,IdentityNumber=124 };

                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(customer1);
                 customerManager.Add(customer2);
                customerManager.Delete(customer2);
                customerManager.Update(customer1);
                customerManager.Update(customer2);




               Campaign campaign1 = new Campaign(){ CampaignName="Campaign1",DiscountRate=50};
               Campaign campaign2=new Campaign() { CampaignName="Campaign2",DiscountRate=70};

                    CampaignManager campaignManager = new CampaignManager();
                    {
                        campaignManager.Add(campaign1);
                        campaignManager.Delete(campaign1);
                        campaignManager.Add(campaign2);
                        campaignManager.Delete(campaign2);

                    }
            SaleManager saleManager = new SaleManager();
            {
                saleManager.Add(new Entities.Sale { GameName = "VALORANT", GamePrice = 500},customer1,campaign1);
                saleManager.Add(new Entities.Sale { GameName = "lol", GamePrice = 600 }, customer2, campaign2);







                }

















}

            
        }
}


        
    
