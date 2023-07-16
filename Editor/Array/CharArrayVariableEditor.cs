using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(CharArrayMutableVariable), editorForChildClasses: true)]
    public class CharArrayVariableEditor : ArrayVariableEditor<char[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).intValue = value.GetArrayElementAtIndex(index).intValue;
        }
    }
}
