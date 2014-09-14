namespace InmNow.Service.Interfaces
{
    public interface IUserNotificationService
    {
        bool SendSuccessEmail();
        bool SendFailureEmail();
    }
}