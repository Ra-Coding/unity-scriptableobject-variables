using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector2MutableVariable), editorForChildClasses: true)]
    public class Vector2VariableEditor : VariableEditor<Vector2>
    {
        protected override void AssignResetValue()
        {
            resetValue.vector2Value = value.vector2Value;
        }
    }
}