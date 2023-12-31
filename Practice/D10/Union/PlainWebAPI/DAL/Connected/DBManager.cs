namespace pwa.dal.connected;
using pwa.bol;
using MySql.Data.MySqlClient;

public class DBManager{
    private static string conString = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";

    public static List<Product> GetAllProducts(){

        List<Product> prodList = new List<Product>();
        //Setting up mysql connection
        MySqlConnection connection= new MySqlConnection();
        connection.ConnectionString = conString;
        try
        {
            string query = "Select * from product;";
            MySqlCommand command = new MySqlCommand(query, connection);
            //Openned connection to database
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Reading from database
                Product product = new Product();
                int id =int.Parse(reader["id"].ToString());
                string title = reader["title"].ToString();
                double unitprice =double.Parse(reader["unitprice"].ToString()); 
                string company =reader["company"].ToString();
                //Assigned values in object after reading
                product.PID=id;
                product.TITLE=title;
                product.UNITPRICE=unitprice;
                product.COMPANY=company;
                //Added all values in product list
                prodList.Add(product);
            }
            //Closed reader
            reader.Close();
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return prodList;
    }

    public static Product GetProductById(int id1){

        Product foundProd = new Product();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString= conString;
        try
        {
            string query = "select * from product where id=@id1";
            MySqlCommand command= new MySqlCommand(query,con);
            command.Parameters.AddWithValue("@id1",id1);
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
            int id =int.Parse(reader["id"].ToString());
            string title = reader["title"].ToString();
            double unitprice =double.Parse(reader["unitprice"].ToString()); 
            string company =reader["company"].ToString();
            //Assigned values in object after reading
            foundProd.PID=id;
            foundProd.TITLE=title;
            foundProd.UNITPRICE=unitprice;
            foundProd.COMPANY=company;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return foundProd;
    }

    public static Product GetProductByCompany(string id1){

        Product foundProd = new Product();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString= conString;
        try
        {
            string query = "select * from product where company=@id";
            MySqlCommand command= new MySqlCommand(query,con);
            command.Parameters.AddWithValue("@id",id1);
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();
            int id =int.Parse(reader["id"].ToString());
            string title = reader["title"].ToString();
            double unitprice =double.Parse(reader["unitprice"].ToString()); 
            string company =reader["company"].ToString();
            //Assigned values in object after reading
            foundProd.PID=id;
            foundProd.TITLE=title;
            foundProd.UNITPRICE=unitprice;
            foundProd.COMPANY=company;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            //Connection Closed
            con.Close();
        }
        return foundProd;
    }
}