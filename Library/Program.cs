using Library;

class Program
    {
    public static void Main()
    {
        Book book = new Book("C# for beginners", "BillGates", "12345678");
        Book book1 = new Book("Ultimate C#", "Microsoft", "87654321");
        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book1.DisplayInfo();
        


        Member member = new Member(1, "John Doe", "123 Main St", "07586123459");
        Member member1 = new Member(2, "Jane Smith", "456 Oak Ave", "07895645326");

        Console.WriteLine("Current library Members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}
