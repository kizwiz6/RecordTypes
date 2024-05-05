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
        public string Name { get; init; }
        public string Address { get; set; }

        /// <summary>
        /// If we want to make properties immutable in the traditional way, we have to pass values in constructor like the below code.
        /// </summary>
        /// <param name="memberId">makes Id property Immutable</param>
        public Member(int memberId)
        {
            Id = memberId;
        }

        public Member(int memberId, string name, string address)
        {
            this.Id = memberId;
            this.Name = name;
            this.Address = address;
        }
    }
}
