namespace Notify;
public class NotificationService{
    public static void NotifyBySMS(string name, string message){
        Console.WriteLine("\nSMS is sent to: "+name+"\nMessage: "+message);
    }
    public static void NotifyByEmail(string name, string message){
        Console.WriteLine("\nEmail is sent to: "+name+"\nMessage: "+message);
    }
    public static void NotifyByWhatsapp(string name, string message){
        Console.WriteLine("\nWhatsapp message is sent to: "+name+"\nMessage: "+message);
    }
}