using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(BoolMutableVariable), editorForChildClasses: true)]
    public class BoolVariableEditor : VariableEditor<bool>
    {
        protected override void AssignResetValue()
        {
            resetValue.boolValue = value.boolValue;
        }
    }
}
