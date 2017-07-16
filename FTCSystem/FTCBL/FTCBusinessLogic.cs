using FTCBL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCBL
{
    
    public class FTCBusinessLogic
    {
       
        public void InsertItemInToInventory(Item item)
        {
            DBHandler.InsertOne(Consts.InventroyCollection, item);
        }
    }
}
