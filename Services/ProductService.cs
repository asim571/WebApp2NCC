using WebApp2ByAsim.Models;

namespace WebApp2ByAsim.Services
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
        {
         new ProductViewModel {Id = 1, Name = "Mobile" },
         new ProductViewModel {Id = 2, Name = "Headphone" },
         new ProductViewModel {Id = 3, Name = "Ipad" },
         new ProductViewModel {Id = 4, Name = "Air Pods" },
         new ProductViewModel {Id = 5, Name = "Laptop" } ,
         new ProductViewModel {Id = 6, Name = "Bluetooth Speaker"}
         };
        }
    }

}
