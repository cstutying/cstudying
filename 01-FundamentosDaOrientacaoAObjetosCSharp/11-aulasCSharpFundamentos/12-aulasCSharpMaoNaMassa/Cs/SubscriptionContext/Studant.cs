using Cs.NotificationContext;
using Cs.SharedContext;

namespace Cs.SubscriptionContext;

public class Student : Base
{
    public Student()
    {
        Subscription = new List<Subscription>();
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }

    public IList<Subscription> Subscription { get; set; }

    public bool IsPremium => Subscription.Any(x => !x.IsInactive);

    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Premium", "O aluno já´tem uma assinatura ativa"));
            return;
        }

        Subscription.Add(subscription);
    }
}