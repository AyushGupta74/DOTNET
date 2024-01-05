namespace DAL;
using BOL;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
public class DBManager
{
    private static string constring = "server=192.168.10.150; port=3306; user=dac2;password=welcome; database=dac2";
    public static List<Employee> GetAll(){
        List<Employee> emplist = new List<Employee>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = constring;
        string query = "select * from employee";
        MySqlCommand command = new MySqlCommand(query, connection);
        try{
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string email = reader["email"].ToString();
                string contact = reader["contact"].ToString();
                emplist.Add(new Employee(id, name, email, contact));
            }
            reader.Close();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return emplist;

    }
    public static Employee GetById(int id1){
        Employee emp = new Employee();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = constring;
        string query = "select * from employee where id=@id";
        
        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@id",id1);
        try{
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string email = reader["email"].ToString();
                string contact = reader["contact"].ToString();
                emp = new Employee(id, name, email, contact);
            }
            reader.Close();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return emp;

    }
    public static void Register(int id, string name, string email, string contact){
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = constring;
        string query = "insert into employee values(@id, @name, @email, @contact)";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@id",id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@email",email);
        command.Parameters.AddWithValue("@contact",contact);
        connection.Open();
        int n = command.ExecuteNonQuery();
        if(n > 0){
            Console.WriteLine("Student Registered Successfully");
        }else {
            Console.WriteLine("Not Registered");
        }
    }
    public static void Update(int id, string name, string email, string contact){
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = constring;
        string query = "update employee set name = @name, email=@email, contact=@contact where id = @id";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@email",email);
        command.Parameters.AddWithValue("@contact",contact);
        connection.Open();
        int n = command.ExecuteNonQuery();
        if(n > 0){
            Console.WriteLine("Student Updated Successfully");
        }else {
            Console.WriteLine("Student Not Updated");
        }
        connection.Close();

    }
    public static void Delete(int id){
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = constring;
        string query = "delete from employee where id = @id";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        int n = command.ExecuteNonQuery();
        if(n > 0){
            Console.WriteLine("Student Deleted Successfully!!!");
        }else {
            Console.WriteLine("Not Deleted!!!");
        }
        connection.Close();
        }
    }
