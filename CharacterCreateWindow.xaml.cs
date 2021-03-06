using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

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

            componentManager = new ComponentManager();
            componentManager.LoadComponents();
            character = new Character(
                RetrieveComponentFromList(0), 
                RetrieveComponentFromList(7),
                RetrieveComponentFromList(16),
                RetrieveComponentFromList(17),
                RetrieveComponentFromList(18),
                RetrieveComponentFromList(49),
                RetrieveComponentFromList(50),
                RetrieveComponentFromList(52),
                RetrieveComponentFromList(54),
                SkinTypesEnums.Base
                );
            layerDictionary = new Dictionary<LayerEnums, System.Windows.Controls.Image>();
            SetViewFront();
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
                BitmapImage displayBitmap = new BitmapImage();
                //For each value in the KeyPair, a bitmap is initialised from the Uri
                displayBitmap.BeginInit();
                displayBitmap.CacheOption = BitmapCacheOption.OnLoad;
                displayBitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                displayBitmap.UriSource = componentLayers.Value;
                displayBitmap.EndInit();
                

                //Code block contained in try as some componentlayers passed will be exluded from dictionary
                //depending on if front or back view is set
                if (layerDictionary.ContainsKey(componentLayers.Key))
                {
                    //A XAML component is identified from the layerlist dictionary
                    var XAMLComponent = layerDictionary[componentLayers.Key];
                    //XAML component source and new source are compared
                    if (XAMLComponent.Source != displayBitmap)
                    {
                        //If values are different, source is updated and the component's
                        //visuals invalidated, forcing a redraw
                        XAMLComponent.Source = displayBitmap;
                        XAMLComponent.InvalidateVisual();
                        displayBitmap.Freeze();
                    }
                }
                //if they match, no action is taken and we iterate to the next keyvalue pairs
                GC.Collect();
            }
        }
        private void SetViewFront()
        {
            layerDictionary.Clear();
            layerDictionary.Add(LayerEnums.Body, this.BodyLayer);
            layerDictionary.Add(LayerEnums.BodyAccessories, this.BodyAccessoriesLayer);
            layerDictionary.Add(LayerEnums.BodyLower, this.BodyLowerLayer);
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
        }
        private void SetViewBack()
        {
            layerDictionary.Clear();
            layerDictionary.Add(LayerEnums.BodyBack, this.BodyLayer);
            layerDictionary.Add(LayerEnums.BodyAccessoriesBack, this.BodyAccessoriesLayer);
            layerDictionary.Add(LayerEnums.BodyUnderwearBack, this.BodyUnderwearLayer);
            layerDictionary.Add(LayerEnums.BodyLowerBack, this.BodyLowerLayer);
            layerDictionary.Add(LayerEnums.BodyMiddleBack, this.BodyMiddleLayer);
            layerDictionary.Add(LayerEnums.BodyTopBack, this.BodyTopLayer);
            layerDictionary.Add(LayerEnums.HeadBack, this.HeadLayer);
            layerDictionary.Add(LayerEnums.HairBack, this.HairBackLayer);
            layerDictionary.Add(LayerEnums.HairBackAccessoriesBack, this.HairBackAccessoriesLayer);
            layerDictionary.Add(LayerEnums.EyeBack, this.EyeLayer);
            layerDictionary.Add(LayerEnums.NoseBack, this.NoseLayer);
            layerDictionary.Add(LayerEnums.MouthBack, this.MouthLayer);
            layerDictionary.Add(LayerEnums.EyeShadowBack, this.EyeShadowLayer);
            layerDictionary.Add(LayerEnums.FaceAccessoriesBack, this.FaceAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HairFrontBack, this.HairFrontLayer);
            layerDictionary.Add(LayerEnums.HairFrontAccessoriesBack, this.HairFrontAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HandsBack, this.HandsLayer);
            layerDictionary.Add(LayerEnums.HandsUnderAccessoriesBack, this.HandsUnderAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HandsUnderwearBack, this.HandsUnderwearLayer);
            layerDictionary.Add(LayerEnums.HandsMiddleBack, this.HandsMiddleLayer);
            layerDictionary.Add(LayerEnums.HandsUpperAccessoriesBack, this.HandsUpperAccessoriesLayer);
            layerDictionary.Add(LayerEnums.HandsTopBack, this.HandsTopLayer);
            layerDictionary.Add(LayerEnums.FeetBack, this.FeetLayer);
            layerDictionary.Add(LayerEnums.FeetUnderAccessoriesBack, this.FeetUnderAccessoriesLayer);
            layerDictionary.Add(LayerEnums.FeetUnderwearBack, this.FeetUnderwearLayer);
            layerDictionary.Add(LayerEnums.FeetMiddleBack, this.FeetMiddleLayer);
            layerDictionary.Add(LayerEnums.FeetTopBack, this.FeetTopLayer);
            layerDictionary.Add(LayerEnums.FeetUpperAccessoriesBack, this.FeetUpperAccessoriesLayer);
            layerDictionary.Add(LayerEnums.BustBack, this.BustLayer);
            layerDictionary.Add(LayerEnums.BustAccessoriesBack, this.BustAccessoriesLayer);
            layerDictionary.Add(LayerEnums.BustUnderwearBack, this.BustUnderwearLayer);
            layerDictionary.Add(LayerEnums.BustMiddleBack, this.BustMiddleLayer);
            layerDictionary.Add(LayerEnums.BustTopBack, this.BustTopLayer);
        }

        /// <summary>
        /// Returns a component object matching the ID integer passed as a parameter
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private CharacterComponent RetrieveComponentFromList(int ID)
        {
            return componentManager.loadedComponets.Find(p => p.ComponentID == ID);

        }

        private void LightPaleButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.LightPale;
            character.BodyComponent = RetrieveComponentFromList(1);
            character.HandComponent = RetrieveComponentFromList(8);
            character.HeadComponent = RetrieveComponentFromList(19);
            character.FeetComponent = RetrieveComponentFromList(33);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void PaleButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.Pale;
            character.BodyComponent = RetrieveComponentFromList(2);
            character.HandComponent = RetrieveComponentFromList(9);
            character.HeadComponent = RetrieveComponentFromList(20);
            character.FeetComponent = RetrieveComponentFromList(34);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void BaseButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.Base;
            character.BodyComponent = RetrieveComponentFromList(0);
            character.HandComponent = RetrieveComponentFromList(7);
            character.HeadComponent = RetrieveComponentFromList(18);
            character.FeetComponent = RetrieveComponentFromList(17);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void TannedButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.Tanned;
            character.BodyComponent = RetrieveComponentFromList(3);
            character.HandComponent = RetrieveComponentFromList(10);
            character.HeadComponent = RetrieveComponentFromList(21);
            character.FeetComponent = RetrieveComponentFromList(35);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void BrownButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.Brown;
            character.BodyComponent = RetrieveComponentFromList(4);
            character.HandComponent = RetrieveComponentFromList(11);
            character.HeadComponent = RetrieveComponentFromList(22);
            character.FeetComponent = RetrieveComponentFromList(36);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void DarkBrownButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.DarkBrown;
            character.BodyComponent = RetrieveComponentFromList(5);
            character.HandComponent = RetrieveComponentFromList(12);
            character.HeadComponent = RetrieveComponentFromList(23);
            character.FeetComponent = RetrieveComponentFromList(37);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.Black;
            character.BodyComponent = RetrieveComponentFromList(6);
            character.HandComponent = RetrieveComponentFromList(13);
            character.HeadComponent = RetrieveComponentFromList(24);
            character.FeetComponent = RetrieveComponentFromList(38);
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            character.SkinType = SkinTypesEnums.White;
            character.BodyComponent = RetrieveComponentFromList(14);
            character.HandComponent = RetrieveComponentFromList(15);
            character.HeadComponent = RetrieveComponentFromList(25);
            character.FeetComponent = RetrieveComponentFromList(39);
            SetBust();
            RedrawLayers(this.character, this.layerDictionary);
        }

        private void SwitchViewButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SwitchViewButton.Content)
            {
                case "View Back":
                    SetViewBack();
                    SwitchViewButton.Content = "View Front";
                    break;

                case "View Front":
                    SetViewFront();
                    SwitchViewButton.Content = "View Back";
                    break;
            }
            RedrawLayers(character, layerDictionary);
            GC.Collect();
        }

        private void TabControl_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //Currently unused
        }

        private void TabControl_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            //Currently unused
        }

        private void SmallBustSize_Click(object sender, RoutedEventArgs e)
        {
            character.BustSize = 2;
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void MediumBustSize_Click(object sender, RoutedEventArgs e)
        {
            character.BustSize = 1;
            SetBust();
            RedrawLayers(character, layerDictionary);
        }

        private void SetBust()
        {
            switch (character.SkinType)
            {
                case SkinTypesEnums.LightPale:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(26);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(41);
                            break;
                    }
                    break;
                case SkinTypesEnums.Pale:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(27);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(42);
                            break;
                    }
                    break;
                case SkinTypesEnums.Tanned:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(28);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(43);
                            break;

                    }
                    break;
                case SkinTypesEnums.Brown:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(29);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(44);
                            break;
                    }
                    break;
                case SkinTypesEnums.DarkBrown:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(30);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(45);
                            break;
                    }
                    break;
                case SkinTypesEnums.Black:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(31);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(46);
                            break;
                    }
                    break;
                case SkinTypesEnums.White:
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(32);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(47);
                            break;
                    }
                    break;
                default: 
                    switch (character.BustSize)
                    {
                        case 1:
                            character.BustComponent = RetrieveComponentFromList(16);
                            break;
                        case 2:
                            character.BustComponent = RetrieveComponentFromList(40);
                            break;
                    }
                    break;
            }       
        }

        private void RedBikiniBottoms_Click(object sender, RoutedEventArgs e)
        {
            character.BodyUnderwearComponent = RetrieveComponentFromList(48);
            RedrawLayers(character, layerDictionary);
        }

        private void RedBikiniTop_Click(object sender, RoutedEventArgs e)
        {
            character.BustUnderwearComponent = RetrieveComponentFromList(51);
            RedrawLayers(character, layerDictionary);
        }

        private void FittedWhiteShirt_Click(object sender, RoutedEventArgs e)
        {
            character.BustMiddleComponent = RetrieveComponentFromList(53);
            RedrawLayers(character, layerDictionary);
        }

        private void ShortBlackPencilSkirt_Click(object sender, RoutedEventArgs e)
        {
            if (character.BustMiddleComponent == RetrieveComponentFromList(53))
            {
                character.BustMiddleComponent = RetrieveComponentFromList(56);
            }
            character.BodyMiddleComponent = RetrieveComponentFromList(55);
            RedrawLayers(character, layerDictionary);
        }
    }
}