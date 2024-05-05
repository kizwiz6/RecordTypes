namespace RecordTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member memberObj = new Member(1, "Kieran", "Cambridgeshire");

            Console.WriteLine("****************START - Member Details***********");

            Console.WriteLine("ID:- " + memberObj.Id);
            Console.WriteLine("Name:- " + memberObj.Name);
            Console.WriteLine("Address:- " + memberObj.Address);
            Console.ReadLine();

            Console.WriteLine("****************END - Member Details***********");
        }
    }
}
