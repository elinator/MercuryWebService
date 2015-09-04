using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercuryWebService
{
    public class Order
    {

        private static Mercury.MercuryServiceClient Service { get; set; }
        //private static int webConfigID = 10718;

        //ELI real config ID
        private static int webConfigID = 19759;
        

        public int externalPONumber { get; set; }              //ELI ORDER TOKEN TIQIQ internal order id to pass to TN
        public int ticketGroupID { get; set; }
        public int quantity { get; set; }
        public decimal wholesalePrice { get; set; }
        private bool overridePrice { get { return false; } }
        public int shippingMethodID { get; set; }
        public string  shippingMethodDesc { get; set; } 
        public decimal shippingPrice { get; set; } 
        public string  shippingInstructions { get; set; } 
        public string  retailCustomerName { get; set; } 
        public string  retailCustomerPhone { get; set; } 
        public string  retailCustomerStreet1 { get; set; } 
        public string  retailCustomerStreet2 { get; set; } 
        public string  retailCustomerCity { get; set; } 
        public string  retailCustomerStateProvince { get; set; } 
        System.Nullable<int> retailCustomerStateProvinceID { get; set; } 
        public string  retailCustomerCountry { get; set; } 
        System.Nullable<int> retailCustomerCountryID { get; set; } 
        public string  retailCustomerEmail { get; set; } 
        public string  retailCustomerZipcode { get; set; } 
        public string  generalPurchaseNotes { get; set; } 
        public System.Guid stage1Guid { get; set; }
        public System.Guid stage2Guid { get; set; }

        static Order()
        {
            Service = new Mercury.MercuryServiceClient();     
        }

        public void Place() 
        {
            var result =Service.CreateMercuryOrder(webConfigID, externalPONumber, ticketGroupID, quantity, wholesalePrice, overridePrice, shippingMethodID, shippingMethodDesc, shippingPrice, shippingInstructions, retailCustomerName, retailCustomerPhone, retailCustomerStreet1, retailCustomerStreet2, retailCustomerCity, retailCustomerStateProvince, retailCustomerStateProvinceID, retailCustomerCountry, retailCustomerCountryID, retailCustomerEmail, retailCustomerZipcode, generalPurchaseNotes, stage1Guid, stage2Guid);
            var success = result.success;

        }
    }
}
