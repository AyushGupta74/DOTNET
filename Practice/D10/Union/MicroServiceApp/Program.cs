using MSA.BOL;
using MSA.BLL;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/helloWorld", ( ) => "Hello World!");
app.MapGet("/api/welcome", ( ) => "Welcome to our MicroService website!!");
app.MapGet("/api/RandomFlower", ( ) => new{Id= 1,Type="Flower", Name= "Rose"});

app.MapGet("/api/msa/activities",   ( ) =>{
    List<Activity> items= ProjectManager.AllActivity();
    return items;
});
app.Run();
