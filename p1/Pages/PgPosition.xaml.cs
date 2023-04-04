﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using p1.Classes;
using static p1.Classes.clEntity;

namespace p1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PgPosition.xaml
    /// </summary>
    public partial class PgPosition : Page
    {
        public PgPosition()
        {
            InitializeComponent();
            DG.ItemsSource = Context.Position.ToList();
        }

        private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CB.SelectedIndex)
            {
                case 0:
                    DG.ItemsSource = Context.Position.ToList().Where(i => i.IDPosition == Convert.ToInt32(tbSearch.Text));
                    break;
                case 1:
                    DG.ItemsSource = Context.Position.ToList().Where(i => i.Name == tbSearch.Text);
                    break;
                case 2:
                    DG.ItemsSource = Context.Position.ToList().Where(i => i.Salary == Convert.ToInt32(tbSearch.Text));
                    break;
            }
        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Context.Position.ToList();
        }

        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBlock x = DG.Columns[0].GetCellContent(DG.Items[DG.SelectedIndex]) as TextBlock;
            IDChange = Convert.ToInt32(x?.Text);
           
        }
    }
}
