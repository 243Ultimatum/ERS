using System;
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
using System.Drawing;

namespace Character_Previewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LightPaleButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();
            
            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }

        private void PaleButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }

        private void BaseButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }

        private void TannedButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }

        private void BrownButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }

        private void DarkBrownButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }
    }
}
