using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector2ArrayMutableVariable), editorForChildClasses: true)]
    public class Vector2ArrayVariableEditor : ArrayVariableEditor<Vector2[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).vector2Value = value.GetArrayElementAtIndex(index).vector2Value;
        }
    }
}
