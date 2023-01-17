using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(StringMutableVariable), editorForChildClasses: true)]
    public class StringVariableEditor : VariableEditor<string>
    {
        protected override void AssignResetValue()
        {
            resetValue.stringValue = value.stringValue;
        }
    }
}