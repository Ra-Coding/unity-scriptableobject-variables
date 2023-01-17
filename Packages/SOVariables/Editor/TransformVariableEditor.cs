using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(TransformMutableVariable), editorForChildClasses: true)]
    public class TransformVariableEditor : VariableEditor<Transform>
    {
        protected override void AssignResetValue()
        {
            resetValue.objectReferenceValue = value.objectReferenceValue;
        }
    }
}