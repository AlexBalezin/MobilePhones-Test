
namespace MobilePhones.Models
{
    public class BaseStation3G : BaseStation
    {
        public new List<Phone3G> Phones { get; set; }

        public void RegisterPhone(Phone3G phone3G)
        {
            //TODO: логика регистрации телефона
            Phones.Add(phone3G);
        }
    }
}
