using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Probnik.Models;
using System.Collections.Generic;
using System.Linq;

namespace Probnik;

public partial class Basket : Window
{

    private List<Product> products = Helper.Basket.ToList();
    public Basket()
    {
        InitializeComponent();
        MainMenuBtn.Click += MainMenuBtn_Click;
        SetData();
    }
    // Метод для перехода к главному окну по кнопке
    private void MainMenuBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
    // Метод для инициализации листбокса
    public void SetData()
    {
        products = Helper.Basket.GroupBy(x => x.Id).Select(y => new Product
        {
            Id = y.Key,
            ProductName = y.First().ProductName,
            ProductDescription = y.First().ProductDescription,
            Manufactures = y.First().Manufactures,
            Price = y.First().Price,
            Images = y.First().Images
        }).ToList(); 
        LBasket.ItemsSource = products;
    }
}