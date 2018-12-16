namespace InvitationV2.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string message);
    }
}