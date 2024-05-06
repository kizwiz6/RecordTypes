namespace RecordTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Member memberObj = new Member(1, "Kieran", "Emery", "Cambridgeshire");

                Console.WriteLine("****************START - Member 1 Details***********");

                Console.WriteLine("ID:- " + memberObj.Id);
                Console.WriteLine("First Name:- " + memberObj.FirstName);
                Console.WriteLine("Last Name:- " + memberObj.LastName);
                Console.WriteLine("Address:- " + memberObj.Address);
                Console.WriteLine("****************END - Member 1 Details***********");
                Console.ReadLine();
                Console.WriteLine("****************START - Member 1 Details UPDATED ***********");

                var memberObj2 = new Member
                {
                    Id = memberObj.Id,
                    FirstName = memberObj.FirstName,
                    LastName = memberObj.LastName,
                    Address = "Bedfordshire"
                };

                Console.WriteLine("ID:- " + memberObj2.Id);
                Console.WriteLine("First Name:- " + memberObj2.FirstName);
                Console.WriteLine("Last Name:- " + memberObj2.LastName);
                Console.WriteLine("Address:- " + memberObj2.Address);
                Console.WriteLine("****************END - Member 1 Details UPDATED ***********");
                Console.ReadLine();
                Console.WriteLine("****************START - Member 2 Details CREATED with RECORD ***********");

                var memberObj3 = new MemberRecord(2, "Colin", "Emery", "Littlehampton");

                // Creating a modified copy of memberObj3 with a different address
                var updatedMemberObj3 = memberObj3 with { Address = "Oxfordshire" };

                Console.WriteLine("ID:- " + updatedMemberObj3.Id);
                Console.WriteLine("First Name:- " + updatedMemberObj3.FirstName);
                Console.WriteLine("Last Name:- " + updatedMemberObj3.LastName);
                Console.WriteLine("Address:- " + updatedMemberObj3.Address);
                Console.WriteLine("****************END - Member 2 Details CREATED ***********");
                Console.ReadLine();



                if (!ExitConsoleApplication())
                {
                    break; // Exit the loop if the user presses 'Q'
                }

            }
        }

        /// <summary>
        /// Prompts the user to continue or exit the console application.
        /// </summary>
        /// <returns>True if the user wants to continue; otherwise, false.</returns>
        private static bool ExitConsoleApplication()
        {
            // Ask the user if they want to continue
            Console.WriteLine("Press 'Q' to quit or any other key to continue.");
            var key = Console.ReadKey().Key;
            return key != ConsoleKey.Q;
        }
    }
}
