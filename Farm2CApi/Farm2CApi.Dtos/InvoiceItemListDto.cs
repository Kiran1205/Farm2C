using System;

namespace Farm2CApi.Dtos
{
    public class InvoiceItemListDto
    {
     
        public Guid InvoiceItemListID { get; set; }
      
        public int ItemPriceID { get; set; }

        public int NoOfUInits { get; set; }

        public override bool Equals(object obj)
        {
            return obj is InvoiceItemListDto list &&
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
