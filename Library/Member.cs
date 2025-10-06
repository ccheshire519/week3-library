using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phoneNumber;

        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Member(int memberid, string name, string address, string phone)
        {
            this.MemberId = memberid;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone Number: {PhoneNumber}");
            Console.WriteLine();
        }
    }
}
