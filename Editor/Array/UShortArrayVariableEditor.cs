using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(UShortArrayMutableVariable), editorForChildClasses: true)]
    public class UshortArrayVariableEditor : ArrayVariableEditor<ushort[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).intValue = value.GetArrayElementAtIndex(index).intValue;
        }
    }
}
