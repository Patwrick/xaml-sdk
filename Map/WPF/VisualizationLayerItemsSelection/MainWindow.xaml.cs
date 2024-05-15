﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Telerik.Windows.Controls.Map;

namespace VisualizationLayerItemsSelection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            LocationRect usa = new LocationRect(
                new Location(50, -120),
                new Location(30, -70));
            this.visualizationLayer.ItemsSource = this.GeneratePoiCollection(50, usa);
        }

        private void GenerateMapItem(
            ObservableCollection<MapItem> data,
            Location location,
            int index)
        {
            MapItem poi = new MapItem(string.Format("Item {0}", index), location);

            data.Add(poi);
        }

        private ObservableCollection<MapItem> GeneratePoiCollection(int count, LocationRect region)
        {
            ObservableCollection<MapItem> data = new ObservableCollection<MapItem>();

            for (int i = 0; i < count; i++)
            {
                Location baseLocation = new Location(
                        region.North - rnd.NextDouble() * region.GeoSize.Height,
                        region.West + rnd.NextDouble() * region.GeoSize.Width);
                this.GenerateMapItem(data, baseLocation, i);
            }

            return data;
        }

        private void LayerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.RemovedItems != null)
            {
                foreach (MapItem item in e.RemovedItems)
                {
                    item.IsSelected = false;
                }
            }

            if (e.AddedItems != null)
            {
                foreach (MapItem item in e.AddedItems)
                {
                    item.IsSelected = true;
                }
            }
        }
    }
}
