using System.Windows;
using System.Windows.Controls;

namespace Receptor.View.UserControls;

public partial class SearchBar : UserControl
{
    public SearchBar()
    {
        InitializeComponent();
    }

    private void HidePlaceholder(object sender, RoutedEventArgs e)
    {
        TextBox textBox = sender as TextBox;

        SearchLabel.Content = String.Empty;

    }

    private void ShowPlaceholder(object sender, RoutedEventArgs e)
    {
        TextBox textBox = sender as TextBox;

        if (string.IsNullOrEmpty(textBox.Text)) SearchLabel.Content = "Vyhledat recepty...";
    }
}