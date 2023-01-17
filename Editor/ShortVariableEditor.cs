using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(ShortMutableVariable), editorForChildClasses: true)]
    public class ShortVariableEditor : VariableEditor<short>
    {
        protected override void AssignResetValue()
        {
            resetValue.intValue = value.intValue;
        }
    }
}