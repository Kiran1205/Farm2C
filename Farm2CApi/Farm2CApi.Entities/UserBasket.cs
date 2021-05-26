using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class UserBasket
    {
        [Key]
        public int UserBasketID { get; set; }
        public int UserInfoID { get; set; }

        public int ItemPriceID { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
