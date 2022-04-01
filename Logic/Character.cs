using System;
using System.Collections.Generic;
using System.Text;

namespace ERSCore
{
    public class Character
    {
        //Body base component, cannot be a "None" component
        BodyBaseComponent BodyComponent { get; }

        public Character(CharacterComponent bodyComponent)
        {
            BodyComponent = bodyComponent as BodyBaseComponent;
        }

        public int GetBodyType()
        {
            return BodyComponent.BodyType;
        }
        public SkinTypesEnums GetSkinType()
        {
            return BodyComponent.SkinType;
        }

        public Dictionary<LayerEnums, Uri> ReturnAllLayers()
        {
            var AllLayers = new Dictionary<LayerEnums, Uri>();
            //Add Body layers
            foreach(KeyValuePair<LayerEnums, Uri> componentLayers in BodyComponent.RenderLayersList)
            {
                AllLayers.Add(componentLayers.Key, componentLayers.Value);
            }
            return AllLayers;
        }


    }
}
