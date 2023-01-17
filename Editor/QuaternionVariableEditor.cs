using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(QuaternionMutableVariable), editorForChildClasses: true)]
    public class QuaternionVariableEditor : VariableEditor<Quaternion>
    {
        protected override void AssignResetValue()
        {
            resetValue.quaternionValue = value.quaternionValue;
        }
    }
}