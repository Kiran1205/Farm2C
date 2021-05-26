using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class Invoice
    {
        [Key]
        public int InvocieID { get; set; }

        public string InvoiceNumber { get; set; }

        public int UserID { get; set; }

        public int AddressID { get; set; }

        public double TotalAmount { get; set; }

        public double Discount { get; set; }

        public int CoupounId { get; set; }

        public string InvoiceItemListID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Invoice invoice &&
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
