using System;
using System.Collections.Generic;
using System.Text;

namespace ERSCore
{
    public class Character
    {
        //Body base component, cannot be a "None" component
        CharacterComponent BodyComponent { get; set; }
        CharacterComponent HandComponent { get; set; }

        public Character(CharacterComponent bodyComponent, CharacterComponent handComponent)
        {
            BodyComponent = bodyComponent;
            HandComponent = handComponent;
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
            return AllLayers;
        }

    }
}
