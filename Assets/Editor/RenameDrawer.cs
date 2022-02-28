using UnityEditor;
using UnityEngine;

namespace Piano
{
    [CustomPropertyDrawer(typeof(RenameAttribute))]
    public class RenameDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (RenameAttribute)this.attribute;
            label.text = attribute.Name;
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
