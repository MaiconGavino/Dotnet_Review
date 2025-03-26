using pooBalta.NotificationContext;
using pooBalta.SharedContext;

namespace pooBalta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscriptions(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotificantion(new Notification( "Premium", "O Aluno já possiu assinatura ativa"));
                return;
            }
            
        }
        
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}