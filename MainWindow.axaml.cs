using Avalonia.Controls;
using Probnik.Context;
using Probnik.Models;
using System.Collections.Generic;
using System.Linq;

namespace Probnik
{
    public partial class MainWindow : Window
    {
        public List<Product> products = Helper.DataObj.Products.ToList();
        public MainWindow()
        {
            InitializeComponent();
            BasketBtn.Click += BasketBtn_Click;
            Right.Click += Right_Click;
            SetData();
        }
        // ����� ��� ���������� ������ � �������
        private void Right_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
            //Helper.Basket.Add(Helper.DataObj.Products[(int)(sender as MenuItem)!.Tag!]);
        }
         
        // ����� ��� �������� � ������� �� ������
        private void BasketBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
            Close();
        } 

        // ����� ��� ������������� ���������
        public void SetData()
        {
            LBProducts.ItemsSource = Helper.DataObj.Products;
        }
    }
}