namespace VtbCalculator.EmailService
{
    public interface IEmailService
    {
        void SendEmail(string to, string cc, string theme, string content);
    }
}