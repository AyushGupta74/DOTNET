using MySql.Data.MySqlClient;

Console.WriteLine("Welcome to Database App");
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString="server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
Console.WriteLine("enter id to display from product table:");
int id = int.Parse(Console.ReadLine());
string query = "select * from product where id = @id";
MySqlCommand command = new MySqlCommand(query,connection);
command.Parameters.AddWithValue("@id",id);

try{
    connection.Open();
    MySqlDataReader reader = command.ExecuteReader();
     while(reader.Read()){
        int id1 = int.Parse(reader["id"].ToString());
        string name = reader["name"].ToString();
        double price1 = double.Parse(reader["price"].ToString());
        int quantity1 = int.Parse(reader["quantity"].ToString());
        Console.WriteLine(id + " " + name + " " + price1 + " " + quantity1 );
    }
    reader.Close();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}

Console.WriteLine("enter id and name to update from product table:");
int id2 = int.Parse(Console.ReadLine());
string newname=Console.ReadLine();
string query1 = "update product set name = @name where id=@id";
MySqlCommand command1 = new MySqlCommand(query1,connection);
command1.Parameters.AddWithValue("@name",newname);
command1.Parameters.AddWithValue("@id",id2);
try{
    command1.ExecuteNonQuery();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}

Console.WriteLine("enter id to delete from product table:");
int id3 = int.Parse(Console.ReadLine());
string query2 = "delete from product where id=@id";
MySqlCommand command2 = new MySqlCommand(query2,connection);
command2.Parameters.AddWithValue("@id",id3);
try{
    command2.ExecuteNonQuery();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}