using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector3IntMutableVariable), editorForChildClasses: true)]
    public class Vector3IntVariableEditor : VariableEditor<Vector3Int>
    {
        protected override void AssignResetValue()
        {
            resetValue.vector3IntValue = value.vector3IntValue;
        }
    }
}