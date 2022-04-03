using System;
using System.Collections.Generic;
using System.Text;

namespace ERSCore
{
    /// <summary>
    /// Base class for all character components
    /// </summary>
    public class CharacterComponent
    { 
        public string ComponentName { get; set; }
        public int ComponentID { get; set; }
        internal bool IsFemaleComponent { get; set; }
        public int BodyType { get; set; }
        public Dictionary<LayerEnums, Uri> RenderLayersList { get; set; }
        public bool IsMultiPartComponent { get; set; }
        public CharacterComponent(string componentName, int componentID,
            bool isFemaleComponent,
             Dictionary<LayerEnums, Uri> renderLayersList,
            int bodyType,
            bool isMultipartComponent)
        {
            ComponentName = componentName;
            ComponentID = componentID;
            IsFemaleComponent = isFemaleComponent;
            RenderLayersList = renderLayersList;
            BodyType = bodyType;
            IsMultiPartComponent = isMultipartComponent;
        }

    }
}
