namespace BOL;
public class TableEmployee
    {
        public int Id{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        // public string Address{get;set;}
        public string Email{get;set;}
        // public int DeptId{get;set;}      
        // public int ManagerId{get;set;}
        public DateTime Dob{get;set;}
        public string Password{get;set;}
        public TableEmployee(){
            
        }
        public TableEmployee(int id, string fname, string lname, string email, DateTime dob , string pw){
            this.Id=id;
            this.FirstName=fname;
            this.LastName=lname;
            this.Email=email;
            this.Dob=dob;
            this.Password=pw;
        }
    }