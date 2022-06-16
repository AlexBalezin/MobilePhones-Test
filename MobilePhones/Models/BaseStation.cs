using MobilePhones.Abstractions;

namespace MobilePhones.Models
{
    public class BaseStation
    {
        public Guid BaseStationId { get; set; }
        public string Name { get; set; }
        public List<IPhone> Phones { get; set; }

        public void ProcessOutgoingCall(IPhone phoneFrom, IPhone phoneTo)
        {
            if (Phones.Contains(phoneFrom) && Phones.Contains(phoneTo))
            {
                //TODO: обработка исходящего звонка
            }
        }
    }
}
