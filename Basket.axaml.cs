using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Probnik;

public partial class Basket : Window
{
    
    public Basket()
    {
        InitializeComponent();
        MainMenuBtn.Click += MainMenuBtn_Click;
        SetData();
    }
    // ����� ��� �������� � �������� ���� �� ������
    private void MainMenuBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
    // ����� ��� ������������� ���������
    public void SetData()
    {
        //LBBasket.ItemsSource = 
    }
}