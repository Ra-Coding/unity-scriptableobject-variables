using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(UIntArrayMutableVariable), editorForChildClasses: true)]
    public class UIntArrayVariableEditor : ArrayVariableEditor<uint[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).intValue = value.GetArrayElementAtIndex(index).intValue;
        }
    }
}
