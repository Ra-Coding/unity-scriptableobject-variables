using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector2IntMutableVariable), editorForChildClasses: true)]
    public class Vector2IntVariableEditor : VariableEditor<Vector2Int>
    {
        protected override void AssignResetValue()
        {
            resetValue.vector2IntValue = value.vector2IntValue;
        }
    }
}