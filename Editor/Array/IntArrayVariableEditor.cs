using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(IntArrayMutableVariable), editorForChildClasses: true)]
    public class IntArrayVariableEditor : ArrayVariableEditor<int[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).intValue = value.GetArrayElementAtIndex(index).intValue;
        }
    }
}
