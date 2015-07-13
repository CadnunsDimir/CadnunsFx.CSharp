using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CadnunsFx.WebDev.Models
{
    public class ProductDatabaseInitializer
        : DropCreateDatabaseAlways<ProductsContext>
    {
        protected override void Seed(ProductsContext context)
        {
            //base.Seed(context);            
        }
        public static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category{
                    CategoryID= 1,
                    CategoryName= "Carros"
                },
                new Category{
                    CategoryID= 2,
                    CategoryName= "Aviões"
                },
                new Category{
                    CategoryID= 3,
                    CategoryName= "Caminhões"
                },
                new Category{
                    CategoryID= 4,
                    CategoryName= "Barcos"
                },
                new Category{
                    CategoryID= 5,
                    CategoryName= "Foguetes"
                }
            };

            return categories;
        }


    }
}