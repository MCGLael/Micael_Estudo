using MinimalASPWEB.Models;
namespace MinimalASPWEB.ValidationProduct
{
    public class ValidationProduct
    {
        public bool IsValid(ProductDto productdto) 
        {
            if (string.IsNullOrWhiteSpace(productdto.Name) || productdto.Price <= 0 || productdto.Stock < 0)
            {
                return false;
            }
            return true;
        }
    }
}
