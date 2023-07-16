using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector4ArrayMutableVariable), editorForChildClasses: true)]
    public class Vector4ArrayVariableEditor : ArrayVariableEditor<Vector4[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).vector4Value = value.GetArrayElementAtIndex(index).vector4Value;
        }
    }
}
