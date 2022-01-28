
namespace API.Domain.Models
{
    public class ProductModel : BaseModel
    {
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
