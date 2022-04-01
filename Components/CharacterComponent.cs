using System;
using System.Collections.Generic;
using System.Text;

namespace ERSCore
{
    /// <summary>
    /// Base class for all character components
    /// </summary>
    public abstract class CharacterComponent
    {
#pragma warning disable CS0169
        public string ComponentName;
        public int ComponentID;
        internal bool IsFemaleComponent;
#pragma warning restore CS0169

    }
}
