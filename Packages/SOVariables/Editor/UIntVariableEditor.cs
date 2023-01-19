using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(UIntMutableVariable), editorForChildClasses: true)]
    public class UIntVariableEditor : VariableEditor<uint>
    {
        protected override void AssignResetValue()
        {
            resetValue.longValue = value.longValue;
        }
    }
}