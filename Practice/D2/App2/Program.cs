using emp;

Employee e1= new Employee(2,"Ayush Gupta");
WageEmployee we1 = new WageEmployee(5,"Akshat Sinha",400);
Console.WriteLine(e1);
Console.WriteLine(e1.ComputePay());
Console.WriteLine(we1);
Console.WriteLine(we1.ComputePay());