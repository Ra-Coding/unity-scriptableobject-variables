using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(Vector3IntArrayMutableVariable), editorForChildClasses: true)]
    public class Vector3IntArrayVariableEditor : ArrayVariableEditor<Vector3Int[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).vector3IntValue = value.GetArrayElementAtIndex(index).vector3IntValue;
        }
    }
}
