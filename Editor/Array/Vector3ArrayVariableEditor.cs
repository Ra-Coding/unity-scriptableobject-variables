using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector3ArrayMutableVariable), editorForChildClasses: true)]
    public class Vector3ArrayVariableEditor : ArrayVariableEditor<Vector3[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).vector3Value = value.GetArrayElementAtIndex(index).vector3Value;
        }
    }
}
