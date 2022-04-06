using System;
using System.Collections.Generic;
using System.Text;

namespace ERSCore
{
    public class Character
    {
        //Body base component, cannot be a "None" component
        public CharacterComponent BodyComponent { get; set; }
        public CharacterComponent HandComponent { get; set; }
        public CharacterComponent BustComponent { get; set; }
        public CharacterComponent FeetComponent { get; set; }
        public CharacterComponent HeadComponent { get; set; }
        public CharacterComponent BodyUnderwearComponent { get; set; }
        public CharacterComponent BustUnderwearComponent { get; set; }
        public CharacterComponent BustMiddleComponent { get; set; }
        public CharacterComponent BodyMiddleComponent { get; set; }
        public int BustSize = 1;
        public int BodySize = 1;
        public SkinTypesEnums SkinType { get; set; }


        public Character(CharacterComponent bodyComponent,
            CharacterComponent handComponent,
            CharacterComponent bustComponent,
            CharacterComponent feetComponent,
            CharacterComponent headComponent,
            CharacterComponent bodyUnderwearComponent,
            CharacterComponent bustUnderwearComponent,
            CharacterComponent bustMiddleComponent,
            CharacterComponent bodyMiddleComponent,
            SkinTypesEnums skinType)
        {
            BodyComponent = bodyComponent;
            HandComponent = handComponent;
            BustComponent = bustComponent;
            FeetComponent = feetComponent;
            HeadComponent = headComponent;
            BodyUnderwearComponent = bodyUnderwearComponent;
            BustUnderwearComponent = bustUnderwearComponent;
            BustMiddleComponent = bustMiddleComponent;
            BodyMiddleComponent = bodyMiddleComponent;
            SkinType = skinType;


        }

        public int GetBodyType()
        {
            return BodyComponent.BodyType;
        }
        public void SetBodyComponent(CharacterComponent bodyComponent)
        {
            BodyComponent = bodyComponent;
        }
        public void SetHandComponent(CharacterComponent handComponent)
        {
            HandComponent = handComponent;
        }

        public Dictionary<LayerEnums, Uri> ReturnAllLayers()
        {
            var AllLayers = new Dictionary<LayerEnums, Uri>();
            //Add Body layers
            foreach(KeyValuePair<LayerEnums, Uri> componentLayers in BodyComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach(KeyValuePair<LayerEnums, Uri> componentLayers in HandComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach(KeyValuePair<LayerEnums, Uri> componentLayers in BustComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach (KeyValuePair<LayerEnums, Uri> componentLayers in FeetComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach (KeyValuePair<LayerEnums, Uri> componentLayers in HeadComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach (KeyValuePair<LayerEnums, Uri> componentLayers in BodyUnderwearComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach (KeyValuePair<LayerEnums, Uri> componentLayers in BustUnderwearComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach (KeyValuePair<LayerEnums, Uri> componentLayers in BustMiddleComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            foreach (KeyValuePair<LayerEnums, Uri> componentLayers in BodyMiddleComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }

            return AllLayers;
        }

    }
}
