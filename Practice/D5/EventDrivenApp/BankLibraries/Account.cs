namespace Bank;
using Tax;
using Notify;
public class Account{
    public event TaxOperation overBalance;
    public event NotificationOperation underBalance;
    public float Balance{get;set;}
    public void Deposit(float dep){
        this.Balance+=dep;
        if(this.Balance>=150000){
            overBalance(5000);
        }
    }
    public void Withdraw(float dep){
        this.Balance-=dep;
        if(this.Balance<=10000){
            underBalance("Dear Ayush","Your account has Low Balance!");
        }
    }
}