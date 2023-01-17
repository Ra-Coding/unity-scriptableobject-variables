using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomPropertyDrawer(typeof(ReadOnlyInInspector))]
    public class ReadOnlyInInspectorDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }
    }
}
