using MobilePhones.Abstractions;
using System.Text.RegularExpressions;

namespace MobilePhones.Models
{
    public class Subscriber : ISubscriber
    {
        public Guid SubscriberId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;

        public string PhoneNumber { get; private set; }

        public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";

        public bool SetPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
            {
                PhoneNumber = phoneNumber;
                return true;
            }
            else
                return false;
        }
    }
}
