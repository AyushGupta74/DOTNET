namespace pwa.dal.alternates;

using pwa.bol;
using System.Text.Json;
using System.Threading.Tasks;

public static class DBManager
{
    public static List<Product> GetAllProducts(){
            List<Product> allProducts=new List<Product>();
            allProducts.Add(new Product { PID = 1, TITLE = "Gerbera", UNITPRICE = 6, COMPANY = "Flower"});
            allProducts.Add(new Product { PID = 2, TITLE = "Rose", UNITPRICE = 15, COMPANY = "Flower"});
            allProducts.Add(new Product { PID = 3, TITLE = "Lotus", UNITPRICE = 26, COMPANY = "Flower"});
            allProducts.Add(new Product { PID = 4, TITLE = "Carnation", UNITPRICE = 16, COMPANY = "Flower"});           
            allProducts.Add(new Product { PID = 6, TITLE = "Jasmine", UNITPRICE = 26, COMPANY = "Flower"});
            allProducts.Add(new Product { PID = 7, TITLE = "Daisy", UNITPRICE = 36, COMPANY = "Flower"});        
            allProducts.Add(new Product { PID = 11, TITLE = "Hydrangea", UNITPRICE = 12, COMPANY = "Flower"});
            allProducts.Add(new Product { PID = 12, TITLE = "Orchid",  UNITPRICE = 10, COMPANY = "Flower"});          
            allProducts.Add(new Product { PID = 15, TITLE = "Tulip", UNITPRICE = 17, COMPANY = "Flower"});
            return allProducts;
    }
    public static List<Product> GetAllProductsFromFile(string path){       
            if(File.Exists(path)){
                string jsonString=File.ReadAllText(path);
            List<Product> allProducts=JsonSerializer.Deserialize<List<Product>>(jsonString);
            return allProducts ;
            }
            else
            {
                return GetAllProducts();
            }  
    }
    public static List<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = new List<Product>();
            
            //Using MYSQL 
            //database connectivity using  ADO.NET (RDBMS)
            //database connectiity using  ORM (Entity Framework)

            //database connectivity using MONGO db
            return allProducts;
        }
    public static List<Product> GetAllProductsFromExternalServices()
        {
            List<Product> allProducts = new List<Product>();
            
            // get all JSON data from REST API
             
            //database connectivity using MONGO db
            return allProducts;
        }

    public    static Product GetProductById(int id){
        List<Product> products = GetAllProducts();
        var product = ( from prod in products
                      where prod.PID == id
                      select prod);
        


        //Product product=new Product { PID = 1, TITLE = "Gerbera", UNITPRICE = 6, COMPANY = "Flower"};

        /* List<product> produts=new List<product>();
         List<product> foundproducts=null;
          foreach( Product p in product){
            if(p.Title=="Gerbera"){
                foundproducts.Add(p);
            }
          }
        */

        return (Product)product; 
    }
}

 