﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Character_Previewer
{
    public class BitmapBuilder
    {
        public BitmapImage BuildBitMap(SkinTypesEnums skinType, LayerEnums layerType)
        {
            Uri resourceUri;
            switch (skinType)
            {
                case SkinTypesEnums.LightPale:
                    switch (layerType)
                    {
                        case LayerEnums.Body:
                            resourceUri = new Uri("pack://application:,,,/Resources/light_pale_body_1_front.png");
                            break;
                        case LayerEnums.Head:
                            resourceUri = new Uri("pack://application:,,,/Resources/light_pale_head_1_front.png");
                            break;
                        case LayerEnums.Bust:
                            resourceUri = new Uri("pack://application:,,,/Resources/light_pale_bust_1_front.png");
                            break;
                        case LayerEnums.Hands:
                            resourceUri = new Uri("pack://application:,,,/Resources/light_pale_hands_1_front.png");
                            break;
                        case LayerEnums.Feet:
                            resourceUri = new Uri("pack://application:,,,/Resources/light_pale_feet_1_front.png");
                            break;
                        default:
                            //TODO - create custom exception class for this
                            throw new Exception();
                    }
                    break;
                case SkinTypesEnums.Pale:
                    switch (layerType)
                    {
                        case LayerEnums.Body:
                            resourceUri = new Uri("pack://application:,,,/Resources/pale_body_1_front.png");
                            break;
                        case LayerEnums.Head:
                            resourceUri = new Uri("pack://application:,,,/Resources/pale_head_1_front.png");
                            break;
                        case LayerEnums.Bust:
                            resourceUri = new Uri("pack://application:,,,/Resources/pale_bust_1_front.png");
                            break;
                        case LayerEnums.Hands:
                            resourceUri = new Uri("pack://application:,,,/Resources/pale_hands_1_front.png");
                            break;
                        case LayerEnums.Feet:
                            resourceUri = new Uri("pack://application:,,,/Resources/pale_feet_1_front.png");
                            break;
                        default:
                            //TODO - create custom exception class for this
                            throw new Exception();
                    }
                    break;
                case SkinTypesEnums.Tanned:
                    switch (layerType)
                    {
                        case LayerEnums.Body:
                            resourceUri = new Uri("pack://application:,,,/Resources/tanned_body_1_front.png");
                            break;
                        case LayerEnums.Head:
                            resourceUri = new Uri("pack://application:,,,/Resources/tanned_head_1_front.png");
                            break;
                        case LayerEnums.Bust:
                            resourceUri = new Uri("pack://application:,,,/Resources/tanned_bust_1_front.png");
                            break;
                        case LayerEnums.Hands:
                            resourceUri = new Uri("pack://application:,,,/Resources/tanned_hands_1_front.png");
                            break;
                        case LayerEnums.Feet:
                            resourceUri = new Uri("pack://application:,,,/Resources/tanned_feet_1_front.png");
                            break;
                        default:
                            //TODO - create custom exception class for this
                            throw new Exception();
                    }
                    break;
                default:
                    switch (layerType)
                    {
                        case LayerEnums.Body:
                            resourceUri = new Uri("pack://application:,,,/Resources/base_body_1_front.png");
                            break;
                        case LayerEnums.Head:
                            resourceUri = new Uri("pack://application:,,,/Resources/base_head_1_front.png");
                            break;
                        case LayerEnums.Bust:
                            resourceUri = new Uri("pack://application:,,,/Resources/base_bust_1_front.png");
                            break;
                        case LayerEnums.Hands:
                            resourceUri = new Uri("pack://application:,,,/Resources/base_hands_1_front.png");
                            break;
                        case LayerEnums.Feet:
                            resourceUri = new Uri("pack://application:,,,/Resources/base_feet_1_front.png");
                            break;
                        default:
                            //TODO - create custom exception class for this
                            throw new Exception();
                    }
                    break;
            }
            BitmapImage returnImage = new BitmapImage();
            returnImage.BeginInit();
            returnImage.CacheOption = BitmapCacheOption.OnLoad;
            returnImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            returnImage.UriSource = resourceUri;
            returnImage.EndInit();
            return returnImage;
        }
    }
}
