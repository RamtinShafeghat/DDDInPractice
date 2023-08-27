using DddInPractice.Logic.Common;

namespace DddInPractice.Logic.Atms
{
    internal class BalanceChangedEventHandler : IHandler<BalanceChangedEvent>
    {
        public void Handle(BalanceChangedEvent domainEvent)
        {
            //submit it to message bus and receive it on another microservice
        }
    }
}
