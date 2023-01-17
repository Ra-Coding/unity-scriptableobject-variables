using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(ByteMutableVariable), editorForChildClasses: true)]
    public class ByteVariableEditor : VariableEditor<byte>
    {
        protected override void AssignResetValue()
        {
            resetValue.intValue = value.intValue;
        }
    }
}