using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(TransformArrayMutableVariable), editorForChildClasses: true)]
    public class TransformArrayVariableEditor : ArrayVariableEditor<Transform[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).objectReferenceValue = value.GetArrayElementAtIndex(index).objectReferenceValue;
        }
    }
}
