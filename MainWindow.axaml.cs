using Avalonia.Controls;
using Probnik.Context;
using Probnik.Models;
using System.Collections.Generic;
using System.Linq;

namespace Probnik
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BasketBtn.Click += BasketBtn_Click;
            Right.Click += Right_Click;
            SetData();
        }
        // Метод для добавления товара в корзину
        private void Right_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var list = LBProducts.SelectedItems as Product;
            if (list == null) return;
            Helper.Basket.Add(new Product
            {
                Id = list.Id,
                ProductName = list.ProductName,
                ProductDescription = list.ProductDescription,
                Manufactures = list.Manufactures,
                Price = list.Price,
                Images = list.Images,
            });
            SetData();
        }
         
        // Метод для перехода к корзине по кнопке
        private void BasketBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
            Close();
        } 

        // Метод для инициализации листбокса
        public void SetData()
        {
            LBProducts.ItemsSource = Helper.DataObj.Products;
        }
    }
}