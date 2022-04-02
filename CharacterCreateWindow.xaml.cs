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
        readonly Character character;
        readonly ComponentManager componentManager;
        readonly Dictionary<LayerEnums, System.Windows.Controls.Image> layerDictionary;
        public CharacterCreateWindow()
        {
            InitializeComponent();
            #region Layer Dictionary Declaration
            layerDictionary = new Dictionary<LayerEnums, System.Windows.Controls.Image>();
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

            componentManager = new ComponentManager();
            componentManager.LoadComponents();
            character = new Character(
                RetrieveComponentFromList(0), 
                RetrieveComponentFromList(7)
                );

            RedrawLayers(character, layerDictionary);

        }
        /// <summary>
        /// Forces all layers in a character's components to be redrawn
        /// </summary>
        /// <param name="character"></param>
        /// <param name="layerDictionary"></param>
        private void RedrawLayers(Character character, Dictionary<LayerEnums, System.Windows.Controls.Image> layerDictionary)
        {
            //Call ReturnAllLayers method in Character to return a list of all the current layers and their URIs
            var LayersToBeRedrawn = character.ReturnAllLayers();
            //Iterates through the list of AllLayers
            foreach(KeyValuePair<LayerEnums, Uri> componentLayers in LayersToBeRedrawn)
            {
                //For each value in the KeyPair, a bitmap is initialised from the Uri
                BitmapImage displayBitmap = new BitmapImage();
                displayBitmap.BeginInit();
                displayBitmap.CacheOption = BitmapCacheOption.OnLoad;
                displayBitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                displayBitmap.UriSource = componentLayers.Value;
                displayBitmap.EndInit();
                //A XAML component is identified from the layerlist dictionary
                var XAMLComponent = layerDictionary[componentLayers.Key];
                //XAML component source and new source are compared
                if (XAMLComponent.Source != displayBitmap)
                {
                    //If values are different, source is updated and the component's
                    //visuals invalidated, forcing a redraw
                    XAMLComponent.Source = displayBitmap;
                    XAMLComponent.InvalidateVisual();
                }
                //if they match, no action is taken and we iterate to the next keyvalue pairs

            }
        }

        /// <summary>
        /// Returns a component object matching the ID integer passed as a parameter
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private CharacterComponent RetrieveComponentFromList(int ID)
        {
            return this.componentManager.loadedComponets.Find(p => p.ComponentID == ID);

        }

        private void LightPaleButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(1);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(8);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.LightPale, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void PaleButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(2);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(9);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Pale, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void BaseButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(0);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(7);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Base, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void TannedButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(3);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(10);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Tanned, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void BrownButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(4);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(11);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Brown, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void DarkBrownButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(5);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(12);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.DarkBrown, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(6);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(13);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.Black, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapBuilder bitmapBuilder = new BitmapBuilder();

            var bodyComponent = RetrieveComponentFromList(14);
            this.character.SetBodyComponent(bodyComponent);

            var handComponent = RetrieveComponentFromList(15);
            this.character.SetHandComponent(handComponent);

            this.HeadLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Head);
            this.HeadLayer.InvalidateVisual();
            this.BustLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Bust);
            this.BustLayer.InvalidateVisual();
            this.FeetLayer.Source = bitmapBuilder.BuildBitMap(SkinTypesEnums.White, LayerEnums.Feet);
            this.FeetLayer.InvalidateVisual();
            RedrawLayers(this.character, this.layerDictionary);
        }
    }
}