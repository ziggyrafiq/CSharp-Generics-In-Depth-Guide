//The File Name is MainWindow.cs
using System.Collections.ObjectModel;
using System.Windows;

namespace GenericCollectionsWPFExample;
public partial class MainWindow : Window
{
    public ViewModel<string> StringViewModel { get; } = new ViewModel<string>();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = StringViewModel;

        // Example: Add some data to the collection
        StringViewModel.DataCollection.Add("Item 1");
        StringViewModel.DataCollection.Add("Item 2");
        StringViewModel.DataCollection.Add("Item 3");
    }
}