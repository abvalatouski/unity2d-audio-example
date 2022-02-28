using UnityEngine;

namespace Piano
{
    public class RenameAttribute : PropertyAttribute
    {
        public RenameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
