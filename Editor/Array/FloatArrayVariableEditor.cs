using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(FloatArrayMutableVariable), editorForChildClasses: true)]
    public class FloatArrayVariableEditor : ArrayVariableEditor<float[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).floatValue = value.GetArrayElementAtIndex(index).floatValue;
        }
    }
}
