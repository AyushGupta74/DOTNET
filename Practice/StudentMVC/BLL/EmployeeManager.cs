namespace BLL;
using BOL;
using DAL;
public class EmployeeManager
{
    public List<TableEmployee> GetAllEmployees(){
        List<TableEmployee> emps = DBManager.GetAllEmployees();
        return emps;
    }

    public void EmployeeCreation(TableEmployee emp){
        DBManager.EmployeeCreation(emp);
    }
}
