using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(ColorArrayMutableVariable), editorForChildClasses: true)]
    public class ColorArrayVariableEditor : ArrayVariableEditor<Color[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).colorValue = value.GetArrayElementAtIndex(index).colorValue;
        }
    }
}
