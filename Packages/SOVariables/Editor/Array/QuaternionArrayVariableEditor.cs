using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(QuaternionArrayMutableVariable), editorForChildClasses: true)]
    public class QuaternionArrayVariableEditor : ArrayVariableEditor<Quaternion[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).quaternionValue = value.GetArrayElementAtIndex(index).quaternionValue;
        }
    }
}
