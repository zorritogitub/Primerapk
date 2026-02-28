namespace MiAppAndroid;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSaludarClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(NombreEntry.Text))
        {
            MensajeLabel.Text = $"¡Hola {NombreEntry.Text}! Bienvenido a Android";
        }
        else
        {
            MensajeLabel.Text = "¡Hola mundo desde Android!";
        }
        MensajeLabel.IsVisible = true;
    }
}