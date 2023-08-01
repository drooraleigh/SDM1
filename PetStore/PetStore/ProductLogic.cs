using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> dictDog;
        private Dictionary<string, CatFood> dictCat;
        
        public ProductLogic() 
        {
            _products = new List<Product>();
            dictDog = new Dictionary<string, DogLeash>();
            dictCat = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                //add to dictDog
                dictDog.Add(product.Name, product as DogLeash);
            } else if (product is CatFood)
            {
                //add to dictCat
                dictCat.Add(product.Name, product as CatFood);
            }
            _products.Add(product); 
        }

        public DogLeash GetDogLeashByName(string name)
        {
            return dictDog[name];
        }


        public List<Product> GetAllProducts() 
        {
            return _products;
        }
    }
}
