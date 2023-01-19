using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(UShortMutableVariable), editorForChildClasses: true)]
    public class UShortVariableEditor : VariableEditor<ushort>
    {
        protected override void AssignResetValue()
        {
            resetValue.intValue = value.intValue;
        }
    }
}