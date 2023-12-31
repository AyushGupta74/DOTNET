namespace MSA.DAL.Connected;
using MSA.BOL;
using MySql.Data.MySqlClient;
public class DBManager{
    public static string conString = "server=192.168.10.150;port=3306;user=dac2;password=welcome;databse=dac2";
    public static List<Activity> GetAllActivity(){
        List<Activity> actlist = new List<Activity>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        string query = "select * from Activity";
        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                Activity act = new Activity();
                int id=int.Parse(reader["id"].ToString());
                string name= reader["name"].ToString();
                bool complete =bool.Parse(reader["IsComplete"].ToString());
                act.Id=id;
                act.Name=name;
                act.IsComplete=complete;
                actlist.Add(act);
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return actlist;
    }

    //public

}