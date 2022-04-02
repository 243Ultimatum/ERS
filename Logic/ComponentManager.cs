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
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Body_Medium",
                    0,
                    true,
                    baseBodyDict,
                    1)
                );

            var lightPaleBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/light_pale_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Body_Medium",
                    1,
                    true,
                    lightPaleBodyDict,
                    1)
                );

            var paleBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/pale_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Body_Medium",
                    2,
                    true,
                    paleBodyDict,
                    1)
                );

            var tannedBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/tanned_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Body_Medium",
                    3,
                    true,
                    tannedBodyDict,
                    1)
                );

            var brownBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/brown_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Body_Medium",
                    4,
                    true,
                    brownBodyDict,
                    1)
                );

            var darkBrownBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/dark_brown_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Body_Medium",
                    5,
                    true,
                    darkBrownBodyDict,
                    1)
                );

            var blackBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/black_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Body_Medium",
                    6,
                    true,
                    blackBodyDict,
                    1)
                );

            var baseHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/base_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Base_Hand_Medium",
                    7,
                    true,
                    baseHandDict,
                    1
                    )
                );

            var lightPaleHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/light_pale_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Light_Pale_Hand_Medium",
                    8,
                    true,
                    lightPaleHandDict,
                    1
                    )
                );

            var paleHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/pale_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Pale_Hand_Medium",
                    9,
                    true,
                    paleHandDict,
                    1
                    )
                );

            var tannedHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/tanned_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Tanned_Hand_Medium",
                    10,
                    true,
                    tannedHandDict,
                    1
                    )
                );

            var brownHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/brown_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Brown_Hand_Medium",
                    11,
                    true,
                    brownHandDict,
                    1
                    )
                );

            var darkBrownHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/dark_brown_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Dark_Brown_Hand_Medium",
                    12,
                    true,
                    darkBrownHandDict,
                    1
                    )
                );

            var blackHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/black_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "Black_Hand_Medium",
                    13,
                    true,
                    blackHandDict,
                    1
                    )
                );

            var whiteBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/white_body_1_front.png") },
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Body_Medium",
                    14,
                    true,
                    whiteBodyDict,
                    1)
                );

            var whiteHandDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/white_hands_1_front.png")}
            };
            loadedComponets.Add(
                new CharacterComponent(
                    "White_Hand_Medium",
                    15,
                    true,
                    whiteHandDict,
                    1
                    )
                );
        }
    }
    
}
