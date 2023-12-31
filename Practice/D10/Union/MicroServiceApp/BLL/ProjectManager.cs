using MSA.BOL;
using MSA.DAL.Manual;
namespace MSA.BLL;
public class ProjectManager{
    public static List<Activity> AllActivity(){
        List<Activity> items=new List<Activity>();
        items= Manual.GetAllActivity();
        //items= DBManager.GetAllActivity();
        return items;
    }

    //
}