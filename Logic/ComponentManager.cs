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
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/base_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Base_Body_Medium",
                    0,
                    true,
                    baseBodyDict,
                    SkinTypesEnums.Base,
                    1)
                );

            var lightPaleBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/light_pale_body_1_front.png") },
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/light_pale_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Light_Pale_Body_Medium",
                    1,
                    true,
                    lightPaleBodyDict,
                    SkinTypesEnums.LightPale,
                    1)
                );

            var paleBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/pale_body_1_front.png") },
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/pale_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Pale_Body_Medium",
                    2,
                    true,
                    paleBodyDict,
                    SkinTypesEnums.Pale,
                    1)
                );

            var tannedBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/tanned_body_1_front.png") },
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/tanned_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Tanned_Body_Medium",
                    3,
                    true,
                    tannedBodyDict,
                    SkinTypesEnums.Tanned,
                    1)
                );

            var brownBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/tanned_body_1_front.png") },
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/tanned_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Brown_Body_Medium",
                    4,
                    true,
                    brownBodyDict,
                    SkinTypesEnums.Brown,
                    1)
                );

            var darkBrownBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/dark_brown_body_1_front.png") },
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/dark_brown_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Dark_Brown_Body_Medium",
                    5,
                    true,
                    darkBrownBodyDict,
                    SkinTypesEnums.DarkBrown,
                    1)
                );

            var blackBodyDict = new Dictionary<LayerEnums, Uri>()
            {
                {LayerEnums.Body, new Uri("pack://application:,,,/Resources/black_body_1_front.png") },
                {LayerEnums.Hands, new Uri("pack://application:,,,/Resources/black_hands_1_front.png") }
            };
            loadedComponets.Add(
                new BodyBaseComponent(
                    "Black_Body_Medium",
                    6,
                    true,
                    blackBodyDict,
                    SkinTypesEnums.Black,
                    1)
                );
        }
    }
    
}
