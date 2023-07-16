using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector2IntArrayMutableVariable), editorForChildClasses: true)]
    public class Vector2IntArrayVariableEditor : ArrayVariableEditor<Vector2Int[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).vector2IntValue = value.GetArrayElementAtIndex(index).vector2IntValue;
        }
    }
}
