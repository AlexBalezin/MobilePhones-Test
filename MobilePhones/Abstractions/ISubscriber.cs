using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones.Abstractions
{
    public interface ISubscriber
    {
        public Guid SubscriberId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string PhoneNumber { get; }

        public string GetFullName();

        public bool SetPhoneNumber(string phoneNumber);
    }
}
