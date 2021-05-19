using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class InvoiceItemList
    {
        
        public Guid InvoiceItemListID { get; set; }

      
        public int ItemPriceID { get; set; }

        public int NoOfUInits { get; set; }

        public override bool Equals(object obj)
        {
            return obj is InvoiceItemList list &&
                   InvoiceItemListID.Equals(list.InvoiceItemListID) &&
                   ItemPriceID == list.ItemPriceID &&
                   NoOfUInits == list.NoOfUInits;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(InvoiceItemListID, ItemPriceID, NoOfUInits);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
