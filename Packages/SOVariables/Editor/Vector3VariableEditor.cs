using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector3MutableVariable), editorForChildClasses: true)]
    public class Vector3VariableEditor : VariableEditor<Vector3>
    {
        protected override void AssignResetValue()
        {
            resetValue.vector3Value = value.vector3Value;
        }
    }
}