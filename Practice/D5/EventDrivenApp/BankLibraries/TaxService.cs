namespace Tax;
public static class TaxService{
    public static void PayIncomeTax(float tax){
        Console.WriteLine("\nIncome Tax: "+tax+" have been deducted from your account.");
    }
    public static void PaySalesTax(float tax){
        Console.WriteLine("\nSales Tax: "+tax+" have been deducted from your account.");
    }
    public static void PayGSTTax(float tax){
        Console.WriteLine("\nGST Tax: "+tax+" have been deducted from your account.");
    }
    public static void PayServiceTax(float tax){
        Console.WriteLine("\nService Tax: "+tax+" have been deducted from your account.");
    }
}