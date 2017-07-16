using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCBL.model
{
    public class Item
    {
        public ObjectId _id { get; set; }

        public string ItemCode { get; set; }

        public string ItemType { get; set; }

        public string Material { get; set; }

        public string Plated { get; set; }

        public string Stones { get; set; }

        public string Colors { get; set; }
        public string ImageName { get; set; }

        public int InStock { get; set; }

        public double UnitPriceUSD { get; set; }

        public double UnitPriceNIS
        {
            get
            {
                return UnitPriceUSD * Consts.USDRate;
            }
        }

        public double WholesalePrice
        {
            get
            {
                return ((UnitPriceNIS * Consts.TaxRate) * Consts.Multiplayer) + Consts.AdditinalCostPerItem;
            }
        }

        public double CustomerPrice
        {
            get
            {
                return WholesalePrice * Consts.CustomerFactor;
            }
        }

        public int PriceOnWebPage { get; set; }

        public Boolean IsItPublishOnWebPage { get; set; }


    }



}
