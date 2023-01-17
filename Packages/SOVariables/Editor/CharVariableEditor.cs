using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(CharMutableVariable), editorForChildClasses: true)]
    public class CharVariableEditor : VariableEditor<char>
    {
        protected override void AssignResetValue()
        {
            resetValue.intValue = value.intValue;
        }
    }
}