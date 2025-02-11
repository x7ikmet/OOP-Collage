
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Project2.Alısveris
{

    class Alısveris{
        
        public static void Run(){
            var categoreis = new Dictionary<string,List<string>>();
            
            AddCategory(categoreis, "Elektronik");
            AddCategory(categoreis, "Giyim");

            AddProductToCategory(categoreis, "Elektronik", "Iphone 11");
            AddProductToCategory(categoreis, "Elektronik", "Iphone 12");
            
            AddProductToCategory(categoreis, "Giyim", "Tişört");
            AddProductToCategory(categoreis, "Giyim", "Ceket");

            ListCategoryAndProducts(categoreis);
            ListProductsInCategory(categoreis, "Giyim");
        }

        static void AddCategory(Dictionary<string,List<string>> categories, string categoryName){
            if (!categories.ContainsKey(categoryName)){
                categories[categoryName] = new List<string>(); 
                Console.WriteLine($"{categoryName} Eklindi!");
            }
        }

        static void AddProductToCategory(Dictionary<string,List<string>> categories,string categoryName, string productName){
            if (categories.ContainsKey(categoryName)){
                if (!categories[categoryName].Contains(productName)){
                    categories[categoryName].Add(productName);
                    Console.WriteLine($"{categoryName} - {productName} Eklindi!");
                }       
            }else{
                Console.WriteLine($"{categoryName} bulunamadı.");
            }
        }

        static void ListCategoryAndProducts(Dictionary<string,List<string>> categories){
            Console.WriteLine("Kategoriler ve Ürünler:");
            foreach(var category in categories){
                Console.WriteLine($"Kategori: {category.Key}");
                foreach(var product in category.Value){
                    Console.WriteLine($"\t- {product}");
                }
            }
        }

        static void ListProductsInCategory(Dictionary<string,List<string>> categories, string categoryName){
            
            Console.WriteLine($"List of products in {categoryName}:");
            foreach(var product in categories[categoryName]){
                Console.WriteLine($"\t- {product}");
            }
        }

    }
}