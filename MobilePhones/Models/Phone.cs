using MobilePhones.Abstractions;

namespace MobilePhones.Models
{
    public class Phone : IPhone
    {
        public string Imei { get; }
        public string NumberSimCard { get; set; }
        public List<ISubscriber> Subscribers { get; set; }

        public Phone(string imei)
        {
            Imei = imei;
        }

        public void ConnectBaseStation()
        {
            //TODO: соединение с базовой станцией
        }

        public void Call(string number)
        {
            //TODO: вызов
        }

        public void Call(ISubscriber subscriber)
        {
            //TODO: вызов
        }
    }
}
