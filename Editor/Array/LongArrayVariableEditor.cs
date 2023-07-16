using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(LongArrayMutableVariable), editorForChildClasses: true)]
    public class LongArrayVariableEditor : ArrayVariableEditor<long[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).longValue = value.GetArrayElementAtIndex(index).longValue;
        }
    }
}
