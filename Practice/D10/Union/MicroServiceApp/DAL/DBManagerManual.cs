namespace MSA.DAL.Manual;
using MSA.BOL;
public class Manual{
    public static List<Activity> GetAllActivity(){
        List<Activity> items=new List<Activity>();
        items.Add(new Activity{ Id=1, Name="Print", IsComplete=false});
        items.Add(new Activity{ Id=2, Name="Code", IsComplete=false});
        items.Add(new Activity{ Id=3, Name="Test", IsComplete=false});
        items.Add(new Activity{ Id=4, Name="Deploy", IsComplete=false});
        items.Add(new Activity{ Id=5, Name="Support", IsComplete=false});
        //Access list from DAL 
        return items;
    }

    //
}