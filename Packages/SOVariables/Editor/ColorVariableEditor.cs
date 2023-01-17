using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(ColorMutableVariable), editorForChildClasses: true)]
    public class ColorVariableEditor : VariableEditor<Color>
    {
        protected override void AssignResetValue()
        {
            resetValue.colorValue = value.colorValue;
        }
    }
}