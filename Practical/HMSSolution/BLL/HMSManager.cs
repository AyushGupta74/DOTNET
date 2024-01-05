namespace BLL;
using BOL;
using DAL;

public class HMSManager
{
    public List<Employee> AllEmployees(){
        List<Employee> emplist = DBManager.GetAll();
        return emplist;
    }
    public Employee EmployeeById(int id){
        Employee emp = DBManager.GetById(id);
        return emp;
    }
    public void Register(int id, string name, string email, string contact){
        DBManager.Register(id, name, email, contact);
    }
    public void Update(int id, string name, string email, string contact){
        DBManager.Update(id, name, email, contact);
    }
     public void Delete(int id){
        DBManager.Delete(id);
    }
}
