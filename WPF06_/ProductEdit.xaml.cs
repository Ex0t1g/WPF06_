using System.Windows;

namespace WPF06_;
public partial class ProductEdit : Window
{
    public ProductEdit()
    {
        InitializeComponent();
    }

    private void Button_Cancel(object sender, RoutedEventArgs e)
    {
        this.DialogResult = false;
    }

    private void Button_Save(object sender, RoutedEventArgs e)
    {
        this.DialogResult = true;
    }
}
