using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector4MutableVariable), editorForChildClasses: true)]
    public class Vector4VariableEditor : VariableEditor<Vector4>
    {
        protected override void AssignResetValue()
        {
            resetValue.vector4Value = value.vector4Value;
        }
    }
}