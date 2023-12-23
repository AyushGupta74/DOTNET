using System.Threading;
using Bank;
using Tax;
using Notify;

Account acc1 = new Account();
acc1.overBalance+= TaxService.PayIncomeTax;
acc1.overBalance+= TaxService.PaySalesTax;
acc1.overBalance+= TaxService.PayGSTTax;
acc1.overBalance+= TaxService.PayServiceTax;
acc1.underBalance+=NotificationService.NotifyBySMS;
acc1.underBalance+=NotificationService.NotifyByEmail;
acc1.underBalance+=NotificationService.NotifyByWhatsapp;

acc1.Balance= 200000;
acc1.Deposit(12000);
float currentBalance=acc1.Balance;
Console.WriteLine( "\nCurrent Balance: "+ currentBalance);

//Synchronous Calling
NotificationService.NotifyBySMS("Ayush", "Your Money is deposited.");
TaxService.PayIncomeTax(7000);

//Asynchronous Calling
TaxOperation Tax1= new TaxOperation(TaxService.PayIncomeTax);
Tax1(7500);

//Attaching functions to delegates
NotificationOperation eventSMS = new NotificationOperation(NotificationService.NotifyBySMS);
NotificationOperation eventEmail = new NotificationOperation(NotificationService.NotifyByEmail);
NotificationOperation eventWhatsappMessage = new NotificationOperation(NotificationService.NotifyByWhatsapp);

NotificationOperation proxy= null;

//Chaining
proxy+= eventSMS;
proxy+= eventEmail;
proxy+= eventWhatsappMessage;

proxy("Pris","Account formed...");

//Dechaining
proxy-= eventWhatsappMessage;
proxy-= eventSMS;
Console.WriteLine("Dechained 2 events.");
proxy("Aditya","Account formed...");

//Invoking
Console.WriteLine("Invoked.");
proxy.Invoke("Aditya","Account is newly generated.");

//BeginInvoking
//IAsyncResult result1= proxy.BeginInvoke("User","Thank-you for visiting...",null,null);
                       
//EndInvoke
//proxy.EndInvoke(result1); 

//Thread
Thread currentThread = Thread.CurrentThread;
int threadId = currentThread.ManagedThreadId;
Console.WriteLine("\nThread: "+ currentThread.Priority +" , ThreadId: "+threadId);

Account acc2=new Account();
//attach event handler with with before working with object 
//operation
acc2.overBalance+= TaxService.PayIncomeTax;
acc2.overBalance+= TaxService.PaySalesTax;
acc2.overBalance+= TaxService.PayGSTTax;
acc2.overBalance+= TaxService.PayServiceTax;
acc2.underBalance+=NotificationService.NotifyBySMS;
acc2.underBalance+=NotificationService.NotifyByEmail;
acc2.underBalance+=NotificationService.NotifyByWhatsapp;

acc2.Balance=167000;
acc2.Withdraw(166000);

//acc2.Deposit(486000);
float currentBalance_2=acc2.Balance;
Console.WriteLine(" Latest Balance of Account: "+currentBalance_2);