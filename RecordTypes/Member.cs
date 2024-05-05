using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    /// <summary>
    /// Represent a member with basic information,
    /// </summary>
    public class Member
    {
        public int Id { get; init; } // init-only setter
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Address { get; set; }

        /// <summary>
        /// Initialises a new instance of the <see cref="Member"/> class with the specified Id.
        /// </summary>
        /// <param name="memberId">The unique identifier of the member.</param>
        public Member(int memberId)
        {
            // Old style of error handling logic
            if (memberId <= 0)
            {
                Id = memberId;
            }
        }

        public Member()
        {

        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Member"/> class with the specified details.
        /// </summary>
        /// <param name="memberId">The unique identifier of the member.</param>
        /// <param name="firstName">The first name of the member.</param>
        /// <param name="lastName">The last name of the member.</param>
        /// <param name="address">The address of the member.</param>
        public Member(int memberId, string firstName, string lastName, string address)
        {
            CheckArgument(memberId > 0, "Member ID must be a positive integer.", nameof(memberId));
            CheckArgument(!string.IsNullOrWhiteSpace(firstName), "First name cannot be null or empty.", nameof(firstName));
            CheckArgument(!string.IsNullOrWhiteSpace(lastName), "Last name cannot be null or empty.", nameof(lastName));
            CheckArgument(!string.IsNullOrWhiteSpace(address), "Address cannot be null or empty.", nameof(address));

            Id = memberId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        /// <summary>
        /// Checks the specified condition and throws an <see cref="ArgumentException"/> if the condition is false.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="message">The error message to include in the exception.</param>
        /// <param name="paramName">The name of the parameter causing the exception.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="condition"/> is false.</exception>
        private static void CheckArgument(bool condition, string message, string paramName)
        {
            if (!condition)
            {
                throw new ArgumentException(message, paramName);
            }
        }
    }
}
