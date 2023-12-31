namespace BLL;
using BOL;
using DAL.Connected;

public class Catalog{
    public List<Product> GetAllProducts(){

        List<Product> productList = DBManager.GetAllProducts();
        return productList;
    }

    public Product GetProductById(int id){

        //List<Product> productList = GetAllProducts();
        //Product prod = productList.Find((Product)=>Product.PID==id);

        Product prod = DBManager.GetProductById(id);
        return prod;
    }
}