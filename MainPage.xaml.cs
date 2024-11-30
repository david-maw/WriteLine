using System.Diagnostics;

namespace Community;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        for (int i = 20; i > 0; i--)
            Debug.WriteLine("*************************************************");
    }
}
