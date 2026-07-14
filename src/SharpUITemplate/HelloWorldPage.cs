namespace SharpUITemplate;

using Sharp.UI;

public sealed partial class HelloWorldPage : ContentPage
{
    int count = 0;

    protected override View Build()
    {
        return new VStack(e => e
            .Spacing(25)
            .Padding(30)
            .CenterVertically())
        {
            new Image("dotnet_bot.png", out var image)
                .HeightRequest(280)
                .CenterHorizontally(),

            new Label("Welcome to Sharp.UI for .NET MAUI")
                .FontSize(e => e.OnPhone(16).Default(30))
                .CenterHorizontally(),

            new Button("Click me")
                .FontSize(20)
                .CenterHorizontally()
                .OnClicked(button =>
                {
                    count++;
                    button.Text = $"Clicked {count} ";
                    button.Text += count == 1 ? "time" : "times";
                })
        };
    }
}