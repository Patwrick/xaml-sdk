﻿using System;
using System.Linq;
using System.Windows;

namespace CustomCaret
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.radRichTextBox.CaretFactory = new SogouCaretFactory();
        }
    }
}