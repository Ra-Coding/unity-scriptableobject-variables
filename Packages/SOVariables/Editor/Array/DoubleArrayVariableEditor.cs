using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(DoubleArrayMutableVariable), editorForChildClasses: true)]
    public class DoubleArrayVariableEditor : ArrayVariableEditor<double[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).doubleValue = value.GetArrayElementAtIndex(index).doubleValue;
        }
    }
}
