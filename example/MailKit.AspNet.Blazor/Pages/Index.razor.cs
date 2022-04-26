namespace MailKit.AspNet.Blazor.Pages
{
    public partial class Index
    {
        void ButtonOnClick()
        {
            EmailSender.Send("testmail@example.com", "ASP.NET Blazor send email example", "Send from ASP.NET Blazor");
        }
    }
}