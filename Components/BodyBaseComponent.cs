using System;
using System.Collections.Generic;

namespace ERSCore
{
    public class BodyBaseComponent : CharacterComponent
    {
        public SkinTypesEnums SkinType { get; }
        public Dictionary<LayerEnums, Uri> RenderLayersList { get; }
        public int BodyType { get; }

        public BodyBaseComponent(string componentName, int componentID, bool isFemaleComponent, Dictionary<LayerEnums, Uri> renderLayersList, SkinTypesEnums skinType, int bodyType)
        {
            ComponentName = componentName;
            ComponentID = componentID;
            IsFemaleComponent = isFemaleComponent;
            RenderLayersList = renderLayersList;
            SkinType = skinType;
            BodyType = bodyType;
        }
    }
}
