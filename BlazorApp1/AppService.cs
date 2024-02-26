using static BlazorApp1.Components.Pages.Weather;

namespace BlazorApp1;

public class AppService
{
    public void PostMessage(string message)
    {
        MessagePosted?.Invoke(this, new Message { Body = message, Sent = DateTime.Now });
    }

    public event EventHandler<Message> MessagePosted;
}
