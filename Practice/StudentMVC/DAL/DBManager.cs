namespace DAL;
using System;
using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public static class DBManager
{
    private static string conString = "server= localhost; port=3306; user= root; password=database; database=student";
    public static List<TableEmployee> GetAllEmployees(){
        List<TableEmployee> emp =new List<TableEmployee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from employee";
        try
        {
            MySqlCommand com = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = com.ExecuteReader();

            while(reader.Read()){
            TableEmployee e =new TableEmployee();

            int id=int.Parse(reader["id"].ToString());
            string fname=reader["firstname"].ToString();
            string lname=reader["lastname"].ToString();
            string email=reader["email"].ToString();
            DateTime dob= DateTime.Parse(reader["dob"].ToString());
            string pw=reader["password"].ToString();

            e.Id=id;
            e.FirstName=fname;
            e.LastName=lname;
            e.Email=email;
            e.Dob=dob;
            e.Password=pw;

            emp.Add(e);
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        con.Close();
        return emp;
    }

    // public static void EmployeeCreation(TableEmployee emp){
    //     MySqlConnection con = new MySqlConnection();
    //     con.ConnectionString = conString;
    //     try
    //     {
    //         con.Open();
    //         string query = "insert into employee values(@id,@fname,@lnam,@email,@dob,@pw)";
    //         Console.WriteLine(emp.LastName);
    //         MySqlCommand command = new MySqlCommand(query, con);
    //         command.Parameters.AddWithValue("@id",emp.Id);
    //         command.Parameters.AddWithValue("@fname",emp.FirstName);
    //         command.Parameters.AddWithValue("@lname",emp.LastName);
    //         command.Parameters.AddWithValue("@email",emp.Email);
    //         command.Parameters.AddWithValue("@dob",emp.Dob);
    //         command.Parameters.AddWithValue("@pw",emp.Password);
    //         command.ExecuteNonQuery();

    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     finally{
    //         con.Close();
    //     }
    // }

    public static void EmployeeCreation(TableEmployee temp){
        
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            con.Open();
            string query = "insert into employee values(@id,@fname,@lname,@email,@dob,@pw)";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@id",temp.Id);
            command.Parameters.AddWithValue("@fname",temp.FirstName);
            command.Parameters.AddWithValue("@lname",temp.LastName);
            command.Parameters.AddWithValue("@email",temp.Email);
            command.Parameters.AddWithValue("@dob",temp.Dob);
            command.Parameters.AddWithValue("@pw",temp.Password);
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
    }
}
