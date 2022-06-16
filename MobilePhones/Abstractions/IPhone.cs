
namespace MobilePhones.Abstractions
{
    public interface IPhone
    {
        public string Imei { get; }
        public string NumberSimCard { get; set; }
        public List<ISubscriber> Subscribers { get; set; }

        public void ConnectBaseStation();

        public void Call(string number);

        public void Call(ISubscriber subscriber);
    }
}
