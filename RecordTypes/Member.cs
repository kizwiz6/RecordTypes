using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    public class Member
    {
        public int Id { get; init; } // init-only setter
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Address { get; set; }

        /// <summary>
        /// If we want to make properties immutable in the traditional way, we have to pass values in constructor like the below code.
        /// </summary>
        /// <param name="memberId">makes Id property Immutable</param>
        public Member(int memberId)
        {
            if (memberId <= 0)
            {
                Id = memberId;
            }
        }

        public Member(int memberId, string firstName, string lastName, string address)
        {
            if (memberId <= 0)
            {
                throw new ArgumentException("Member ID must be a positive integer.", nameof(memberId));
            }

            if(string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));
            }

            if(string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be null or empty.", nameof(firstName));
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address cannot be null or empty.", nameof(address));
            }

            this.Id = memberId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
    }
}
