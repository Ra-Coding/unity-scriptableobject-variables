using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(SByteArrayMutableVariable), editorForChildClasses: true)]
    public class SByteArrayVariableEditor : ArrayVariableEditor<sbyte[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).intValue = value.GetArrayElementAtIndex(index).intValue;
        }
    }
}
