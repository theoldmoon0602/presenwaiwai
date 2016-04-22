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
using System.Windows.Shapes;

namespace presenwaiwai
{
    /// <summary>
    /// Interaction logic for comments.xaml
    /// </summary>
    public partial class CommentList : Window
    {
        public CommentList()
        {
            InitializeComponent();
        }
        public void AddComment(string comment)
        {
            if (!CheckAccess())
            {
                Dispatcher.BeginInvoke(new Action(() => AddComment(comment)));
                return;
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = comment;

            listBox.Items.Add(item);
        }


        private void commentListWindow_Loaded(object sender, RoutedEventArgs e)
        {
            commentListWindow.WindowStyle = WindowStyle.ToolWindow;
        }
    }
}
