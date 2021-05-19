using System;

namespace Farm2CApi.Dtos
{
    public class InvoiceDto
    {
      
        public int InvocieID { get; set; }

        public int InvoiceNumber { get; set; }

        public int UserID { get; set; }

        public int AddressID { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal Discount { get; set; }

        public int CoupounId { get; set; }

        public Guid InvoiceItemListID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is InvoiceDto invoice &&
                   InvocieID == invoice.InvocieID &&
                   InvoiceNumber == invoice.InvoiceNumber &&
                   UserID == invoice.UserID &&
                   AddressID == invoice.AddressID &&
                   TotalAmount == invoice.TotalAmount &&
                   Discount == invoice.Discount &&
                   CoupounId == invoice.CoupounId &&
                   InvoiceItemListID.Equals(invoice.InvoiceItemListID);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(InvocieID, InvoiceNumber, UserID, AddressID, TotalAmount, Discount, CoupounId, InvoiceItemListID);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
