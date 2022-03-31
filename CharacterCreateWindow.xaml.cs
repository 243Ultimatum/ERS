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

namespace ERSCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CharacterCreateWindow : Window
    {
        public CharacterCreateWindow()
        {
            InitializeComponent();
            #region Layer Dictionary Declaration
            Dictionary<LayerEnums, System.Windows.Controls.Image> layerDictionary = new Dictionary<LayerEnums, System.Windows.Controls.Image>();
            layerDictionary.Add(LayerEnums.Body, this.BodyLayer);
            layerDictionary.Add(LayerEnums.BodyAccessories, this.BodyAccessoriesLayer);
            layerDictionary.Add(LayerEnums.BodyUnderwear, this.BodyUnderwearLayer);
            layerDictionary.Add(LayerEnums.BodyMiddle, this.BodyMiddleLayer);
            layerDictionary.Add(LayerEnums.BodyTop, this.BodyTopLayer);
            layerDictionary.Add(LayerEnums.Head, this.HeadLayer);
            layerDictionary.Add(LayerEnums.HairBack, this.HairBackLayer);
            layerDictionary.Add(LayerEnums.HairBackAccessories, this.HairBackAccessoriesLayer);
            layerDictionary.Add(LayerEnums.Eye, this.EyeLayer);
            layerDictionary.Add(LayerEnums.Nose, this.NoseLayer);
            layerDictionary.Add(LayerEnums.Mouth, this.MouthLayer);
            layerDictionary.Add(LayerEnums.EyeShadow, this.EyeShadowLayer);
            layerDictionary.Add(LayerEnums.FaceAccessories, this.FaceAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HairFront, this.HairFrontLayer);
            layerDictionary.Add(LayerEnums.HairFrontAccessories, this.HairFrontAccessoriesLayer);
            layerDictionary.Add(LayerEnums.Hands, this.HandsLayer);
            layerDictionary.Add(LayerEnums.HandsUnderAccessories, this.HandsUnderAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HandsUnderwear, this.HandsUnderwearLayer);
            layerDictionary.Add(LayerEnums.HandsMiddle, this.HandsMiddleLayer);
            layerDictionary.Add(LayerEnums.HandsUpperAccessories, this.HandsUpperAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HandsTop, this.HandsTopLayer);
            layerDictionary.Add(LayerEnums.Feet, this.FeetLayer);
            layerDictionary.Add(LayerEnums.FeetUnderAccessories, this.FeetUnderAccessoriesLayer);
            layerDictionary.Add(LayerEnums.FeetUnderwear, this.FeetUnderwearLayer);
            layerDictionary.Add(LayerEnums.FeetMiddle, this.FeetMiddleLayer);
            layerDictionary.Add(LayerEnums.FeetTop, this.FeetTopLayer);
            layerDictionary.Add(LayerEnums.FeetUpperAccessories, this.FeetUpperAccessoriesLayer);
            layerDictionary.Add(LayerEnums.Bust, this.BustLayer);
            layerDictionary.Add(LayerEnums.BustAccessories, this.BustAccessoriesLayer);
            layerDictionary.Add(LayerEnums.BustUnderwear, this.BustUnderwearLayer);
            layerDictionary.Add(LayerEnums.BustMiddle, this.BustMiddleLayer);
            layerDictionary.Add(LayerEnums.BustTop, this.BustTopLayer);
            #endregion

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

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            this.BodyLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Body);
            this.BodyLayer.InvalidateVisual();
            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.HandsLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Hands);
            this.HandsLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();

        }
    }
}