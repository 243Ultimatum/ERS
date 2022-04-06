using System;
using System.Collections.Generic;
using System.Text;

namespace ERSCore
{
    class ComponentManager
    {
        public List<CharacterComponent> loadedComponets;

        public ComponentManager()
        {
            loadedComponets = new List<CharacterComponent>();
        }
        

        public void LoadComponents()
        {
            //TODO - Add logic to pull these components from JSON files rather than hardcoded


            //Hard-coded values for now
            //BaseBody
            var baseBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/base_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/base_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Body_Medium",
                    0,
                    true,
                    baseBodyDict,
                    1,
                    false)
                );

            var lightPaleBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/light_pale_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/light_pale_body_1_back.png") }

            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Body_Medium",
                    1,
                    true,
                    lightPaleBodyDict,
                    1,
                    false)
                );

            var paleBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/pale_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/pale_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Body_Medium",
                    2,
                    true,
                    paleBodyDict,
                    1,
                    false)
                );

            var tannedBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/tanned_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/tanned_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Body_Medium",
                    3,
                    true,
                    tannedBodyDict,
                    1,
                    false)
                );

            var brownBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/brown_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/brown_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Body_Medium",
                    4,
                    true,
                    brownBodyDict,
                    1,
                    false)
                );

            var darkBrownBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/dark_brown_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/dark_brown_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Body_Medium",
                    5,
                    true,
                    darkBrownBodyDict,
                    1,
                    false)
                );

            var blackBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/black_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/black_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Body_Medium",
                    6,
                    true,
                    blackBodyDict,
                    1,
                    false)
                );

            var baseHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/base_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/base_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Hand_Medium",
                    7,
                    true,
                    baseHandDict,
                    1,
                    false)
                );

            var lightPaleHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/light_pale_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/light_pale_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Hand_Medium",
                    8,
                    true,
                    lightPaleHandDict,
                    1,
                    false)
                );

            var paleHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/pale_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/pale_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Hand_Medium",
                    9,
                    true,
                    paleHandDict,
                    1,
                    false)
                );

            var tannedHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/tanned_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/tanned_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Hand_Medium",
                    10,
                    true,
                    tannedHandDict,
                    1,
                    false)
                );

            var brownHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/brown_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/brown_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Hand_Medium",
                    11,
                    true,
                    brownHandDict,
                    1,
                    false)
                );

            var darkBrownHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/dark_brown_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/dark_brown_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Hand_Medium",
                    12,
                    true,
                    darkBrownHandDict,
                    1,
                    false)
                );

            var blackHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/black_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/black_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Hand_Medium",
                    13,
                    true,
                    blackHandDict,
                    1,
                    false)
                );

            var whiteBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/white_body_1_front.png") },
                {LayerEnums.BodyBack, new Uri("pack://application:,,,/Resources/white_body_1_back.png") }
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Body_Medium",
                    14,
                    true,
                    whiteBodyDict,
                    1,
                    false)
                );

            var whiteHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/white_hands_1_front.png")},
                {LayerEnums.HandsBack, new Uri("pack://application:,,,/Resources/white_hands_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Hand_Medium",
                    15,
                    true,
                    whiteHandDict,
                    1,
                    false)
                );

            var baseBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/base_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/base_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Bust_Medium",
                    16,
                    true,
                    baseBustDict,
                    1,
                    false)
                );

            var baseFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/base_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/base_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Feet_Medium",
                    17,
                    true,
                    baseFeetDict,
                    1,
                    false)
                );

            var baseHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/base_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/base_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Head_Medium",
                    18,
                    true,
                    baseHeadDict,
                    1,
                    false)
                );

            var lightPaleHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/light_pale_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/light_pale_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Head_Medium",
                    19,
                    true,
                    lightPaleHeadDict,
                    1,
                    false)
                );

            var paleHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/pale_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/pale_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Head_Medium",
                    20,
                    true,
                    paleHeadDict,
                    1,
                    false)
                );

            var tannedHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/tanned_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/tanned_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Head_Medium",
                    21,
                    true,
                    tannedHeadDict,
                    1,
                    false)
                );

            var brownHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/brown_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/brown_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Head_Medium",
                    22,
                    true,
                    brownHeadDict,
                    1,
                    false)
                );

            var darkBrownHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/dark_brown_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/dark_brown_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Head_Medium",
                    23,
                    true,
                    darkBrownHeadDict,
                    1,
                    false)
                );

            var blackHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/black_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/black_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Head_Medium",
                    24,
                    true,
                    blackHeadDict,
                    1,
                    false)
                );

            var whiteHeadDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Head, new Uri("pack://application:,,,/Resources/white_head_1_front.png")},
                {LayerEnums.HeadBack, new Uri("pack://application:,,,/Resources/white_head_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Head_Medium",
                    25,
                    true,
                    whiteHeadDict,
                    1,
                    false)
                );

            var lightPaleBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/light_pale_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/light_pale_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Bust_Medium",
                    26,
                    true,
                    lightPaleBustDict,
                    1,
                    false)
                );

            var paleBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/pale_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/pale_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Bust_Medium",
                    27,
                    true,
                    paleBustDict,
                    1,
                    false)
                );

            var tannedBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/tanned_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/tanned_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Bust_Medium",
                    28,
                    true,
                    tannedBustDict,
                    1,
                    false)
                );

            var brownBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/brown_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/brown_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Bust_Medium",
                    29,
                    true,
                    brownBustDict,
                    1,
                    false)
                );

            var darkBrownBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/dark_brown_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/dark_brown_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Bust_Medium",
                    30,
                    true,
                    darkBrownBustDict,
                    1,
                    false)
                );

            var blackBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/black_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/black_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Bust_Medium",
                    31,
                    true,
                    blackBustDict,
                    1,
                    false)
                );

            var whiteBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/white_bust_1_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/white_bust_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Bust_Medium",
                    32,
                    true,
                    whiteBustDict,
                    1,
                    false)
                );

            var lightPaleFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/light_pale_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/light_pale_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Feet_Medium",
                    33,
                    true,
                    lightPaleFeetDict,
                    1,
                    false)
                );

            var paleFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/pale_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/pale_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Feet_Medium",
                    34,
                    true,
                    paleFeetDict,
                    1,
                    false)
                );

            var tannedFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/tanned_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/tanned_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Feet_Medium",
                    35,
                    true,
                    tannedFeetDict,
                    1,
                    false)
                );

            var brownFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/brown_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/brown_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Feet_Medium",
                    36,
                    true,
                    brownFeetDict,
                    1,
                    false)
                );

            var darkBrownFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/dark_brown_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/dark_brown_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Feet_Medium",
                    37,
                    true,
                    darkBrownFeetDict,
                    1,
                    false)
                );

            var blackFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/black_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/black_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Feet_Medium",
                    38,
                    true,
                    blackFeetDict,
                    1,
                    false)
                );

            var whiteFeetDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Feet, new Uri("pack://application:,,,/Resources/white_feet_1_front.png")},
                {LayerEnums.FeetBack, new Uri("pack://application:,,,/Resources/white_feet_1_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Feet_Medium",
                    39,
                    true,
                    whiteFeetDict,
                    1,
                    false)
                );

            var baseSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/base_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/base_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Bust_Small_Body_Medium",
                    40,
                    true,
                    baseSmallBustDict,
                    1,
                    false)
                );

            var lightPaleSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/light_pale_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/light_pale_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Bust_Small_Body_Medium",
                    41,
                    true,
                    lightPaleSmallBustDict,
                    1,
                    false)
                );

            var paleSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/pale_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/pale_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Bust_Small_Body_Medium",
                    42,
                    true,
                    paleSmallBustDict,
                    1,
                    false)
                );

            var tannedSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/tanned_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/tanned_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Bust_Small_Body_Medium",
                    43,
                    true,
                    tannedSmallBustDict,
                    1,
                    false)
                );

            var brownSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/brown_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/brown_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Bust_Small_Body_Medium",
                    44,
                    true,
                    brownSmallBustDict,
                    1,
                    false)
                );

            var darkBrownSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/dark_brown_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/dark_brown_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Bust_Small_Body_Medium",
                    45,
                    true,
                    darkBrownSmallBustDict,
                    1,
                    false)
                );

            var blackSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/black_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/black_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Bust_Small_Body_Medium",
                    46,
                    true,
                    blackSmallBustDict,
                    1,
                    false)
                );

            var whiteSmallBustDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Bust, new Uri("pack://application:,,,/Resources/white_bust_2_front.png")},
                {LayerEnums.BustBack, new Uri("pack://application:,,,/Resources/white_bust_2_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Bust_Small_Body_Medium",
                    47,
                    true,
                    whiteSmallBustDict,
                    1,
                    false)
                );

            var redBikiniMediumDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BodyUnderwear, new Uri("pack://application:,,,/Resources/red_bikini_medium_front.png")},
                {LayerEnums.BodyUnderwearBack, new Uri("pack://application:,,,/Resources/red_bikini_medium_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Red_Bikini_Bottoms_Medium",
                    48,
                    true,
                    redBikiniMediumDict,
                    1,
                    false)
                );

            var bodyUnderwearNoneDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BodyUnderwear, new Uri("pack://application:,,,/Resources/blank_layer.png")},
                {LayerEnums.BodyUnderwearBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Body_Underwear_None",
                    49,
                    true,
                    bodyUnderwearNoneDict,
                    1,
                    false)
                );

            var bustUnderwearNoneDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BustUnderwear, new Uri("pack://application:,,,/Resources/blank_layer.png")},
                {LayerEnums.BustUnderwearBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Bust_Underwear_None",
                    50,
                    true,
                    bustUnderwearNoneDict,
                    1,
                    false)
                );

            var redBikiniTopMediumDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BustUnderwear, new Uri("pack://application:,,,/Resources/red_bikini_top_medium_front.png")},
                {LayerEnums.BustUnderwearBack, new Uri("pack://application:,,,/Resources/red_bikini_top_medium_back.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Red_Bikini_Top_Medium",
                    51,
                    true,
                    redBikiniTopMediumDict,
                    1,
                    false)
                );


            var bustMiddleNoneDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BustMiddle, new Uri("pack://application:,,,/Resources/blank_layer.png")},
                {LayerEnums.BustMiddleBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Bust_Middle_None",
                    52,
                    true,
                    bustMiddleNoneDict,
                    1,
                    false)
                );

            var fittedWhiteShirtDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BustMiddle, new Uri("pack://application:,,,/Resources/fitted_shirt_white_medium_full_length_front.png")},
                {LayerEnums.BustMiddleBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Fitted_Shirt_White_Full_Length",
                    53,
                    true,
                    fittedWhiteShirtDict,
                    1,
                    false)
                );
            //black_short_pencilskirt_medium_front.png
            var bodyMiddleLayerNoneDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BodyMiddle, new Uri("pack://application:,,,/Resources/blank_layer.png")},
                {LayerEnums.BodyMiddleBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Body_Middle_None",
                    54,
                    true,
                    bodyMiddleLayerNoneDict,
                    1,
                    false)
                );

            var blackShortPencilSkirtDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BodyMiddle, new Uri("pack://application:,,,/Resources/black_short_pencilskirt_medium_front.png")},
                {LayerEnums.BodyMiddleBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Short_Pencil_Skirt",
                    55,
                    true,
                    blackShortPencilSkirtDict,
                    1,
                    false)
                );

            var skirtShortFittedWhiteShirtDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.BustMiddle, new Uri("pack://application:,,,/Resources/fitted_shirt_white_medium_pencilskirt_length_front.png")},
                {LayerEnums.BustMiddleBack, new Uri("pack://application:,,,/Resources/blank_layer.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Fitted_Shirt_White_Pencil_Skirt",
                    56,
                    true,
                    skirtShortFittedWhiteShirtDict,
                    1,
                    false)
                );
        }
    } 
}
