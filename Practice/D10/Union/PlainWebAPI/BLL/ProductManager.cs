namespace pwa.bll;
using pwa.bol;
//using pwa.dal.alternates;
using pwa.dal.connected;
//using DAL.DisConnected;
public class ProductManager
{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts= DBManager.GetAllProducts();
        return allProducts;
    }

     public Product GetProduct(int id){
      Product product = new Product();
        product= DBManager.GetProductById(id);
      //LINQ Query
     /* var product=from  p in allProducts
                   where p.ProductId ==id
                    select p  ;     
    */
      //Product product=allProducts.Find((product)=>product.PID ==id);
      return product ;
     }

     public Product GetProductByCompany(string name){
      List<Product> allProducts=GetAllProducts();
      //LINQ Query
     /* var product=from  p in allProducts
                   where p.ProductId ==id
                    select p  ;     
    */
      Product product=allProducts.Find((product)=>product.COMPANY ==name);
      return product ;
     }
}