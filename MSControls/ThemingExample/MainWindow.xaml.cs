﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Telerik.Windows.Controls;

namespace Theming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
			InitializeComponent();
			this.listBox.ItemsSource = Conference.GetConferences();
			this.listBox.SelectedIndex = 2;
		}

		private void Office_Black_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Office_Silver_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office_Silver;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office_Silver;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Office_Blue_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Summer_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Summer;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Summer;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Vista_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Vista;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Vista;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Windows8_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Windows8Touch_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Windows8Touch;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Windows8Touch;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Transparent_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Transparent;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Transparent;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			ImageBrush ib = new ImageBrush();

            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Theming;component/Images/bg04.jpg", UriKind.Absolute));
			this.container.Background = ib;
		}

		private void Windows7_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Windows7;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Windows7;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Expression_Dark_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			this.container.Background = new SolidColorBrush() { Color = Color.FromArgb(255, 28, 28, 28) };
		}

		private void Office2013_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office2013;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office2013;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.White);
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Office2013_LightGray_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office2013;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office2013;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.LightGray);
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void Office2013_DarkGray_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office2013;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Office2013;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void VisualStudio2013_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.VisualStudio2013;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Light);
			this.container.Background = new SolidColorBrush(Colors.White);
		}

		private void VisualStudio2013_Dark_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.VisualStudio2013;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Dark);
			this.container.Background = new SolidColorBrush() { Color = Color.FromArgb(255, 45, 45, 48) };
		}

		private void VisualStudio2013_Blue_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.VisualStudio2013;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Blue);
			this.container.Background = new SolidColorBrush(Colors.White);
		}

        private void Green_Light_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
            });
            GreenPalette.LoadPreset(GreenPalette.ColorVariation.Light);
            this.container.Background = new SolidColorBrush(Colors.White);
        }

        private void Green_Dark_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
            });
            GreenPalette.LoadPreset(GreenPalette.ColorVariation.Dark);
            this.container.Background = new SolidColorBrush() { Color = Color.FromArgb(255, 45, 45, 48) };
        }

        private void Office2016_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Office2016;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Office2016;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
            });
            this.container.Background = new SolidColorBrush(Colors.White);
        }

        private void Office2016Touch_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Office2016Touch;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Office2016Touch;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
            });
            this.container.Background = new SolidColorBrush(Colors.White);
        }

		private void Material_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
			});
			Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
			{
				Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
			});
			if (container != null)
			{
				this.container.Background = new SolidColorBrush(Colors.White);
			}
        }
        private void Fluent_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
            });
            FluentPalette.LoadPreset(FluentPalette.ColorVariation.Light);
            if (container != null)
            {
                ImageBrush ib = new ImageBrush();
                ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Theming;component/Images/bgFluent.png", UriKind.Absolute));
                this.container.Background = ib;
            }
        }

        private void Fluent_Dark_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
            });
            FluentPalette.LoadPreset(FluentPalette.ColorVariation.Dark);
            if (container != null)
            {
                ImageBrush ib = new ImageBrush();
                ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Theming;component/Images/bgFluentDark.png", UriKind.Absolute));
                this.container.Background = ib;
            }
        }
    }
}
