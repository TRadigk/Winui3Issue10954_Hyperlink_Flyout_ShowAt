using System.Diagnostics;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Documents;

namespace App1;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Hyperlink_OnClick(Hyperlink sender, HyperlinkClickEventArgs args)
    {
        var flyoutShowOptions = new FlyoutShowOptions()
        {
            Placement = FlyoutPlacementMode.Auto
        };

        var flyout = new Flyout()
        {
            Content = new TextBlock()
            {
                Text = "Hello, World!"
            }
        };
        flyout.ShowAt(sender, flyoutShowOptions);
    }
}