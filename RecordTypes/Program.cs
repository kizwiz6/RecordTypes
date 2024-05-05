namespace RecordTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Member memberObj = new Member(0, "", "Emery", "Cambridgeshire");

                Console.WriteLine("****************START - Member Details***********");

                Console.WriteLine("ID:- " + memberObj.Id);
                Console.WriteLine("First Name:- " + memberObj.FirstName);
                Console.WriteLine("Last Name:- " + memberObj.LastName);
                Console.WriteLine("Address:- " + memberObj.Address);
                Console.ReadLine();

                Console.WriteLine("****************END - Member Details***********");

            }



            //var newMember = new Member
            //{
            //    Id = member.Id,
            //    FirstName = member.FirstName,
            //    LastName = member.LastName,
            //    Address = "Mumbai"
            //};
        }
    }
}
