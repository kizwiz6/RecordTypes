namespace RecordTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Member memberObj = new Member(1, "Kieran", "Emery", "Cambridgeshire");

                Console.WriteLine("****************START - Member Details***********");

                Console.WriteLine("ID:- " + memberObj.Id);
                Console.WriteLine("First Name:- " + memberObj.FirstName);
                Console.WriteLine("Last Name:- " + memberObj.LastName);
                Console.WriteLine("Address:- " + memberObj.Address);
                Console.ReadLine();

                Console.WriteLine("****************END - Member Details***********");

                var newMember = new Member
                {
                    Id = memberObj.Id,
                    FirstName = memberObj.FirstName,
                    LastName = memberObj.LastName,
                    Address = "Bedfordshire"
                };

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
