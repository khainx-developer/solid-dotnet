namespace SolidPrinciples;

public interface ISmtpClient
{
    void SendEmail(string email);
}

public class UserService
{
    private ISmtpClient _smtpClient;

    public UserService(ISmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public void RegisterAccount(string email)
    {
        if (ValidateEmail(email))
        {
            SendEmail(email);
        }
    }

    // UserService shouldn't validate email
    public bool ValidateEmail(string email)
    {
        return email.Contains("@");
    }

    // UserService shouldn't send email
    public void SendEmail(string email)
    {
        _smtpClient.SendEmail(email);
    }
}