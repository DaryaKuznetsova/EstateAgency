using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class AddDeleteUpdateMethods
    {
        public static void AddEstateObject(EstateAgency db, int statusId, int ownerId, decimal price, string address, int districtId, string descroption, int realtyType, int tradeType, float area)
        {
            EstateObjects eo = new EstateObjects
            {
                StatusId = statusId,
                OwnerId = ownerId,
                Price = price,
                Address = address,
                DistrictId = districtId,
                Description = descroption,
                RealtyTypeId = realtyType,
                TradeTypeId = tradeType,
                Area=area
            };
            db.EstateObjects.Add(eo);
            db.SaveChanges();
        }
    }
}
