using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(IntMutableVariable), editorForChildClasses: true)]
    public class IntVariableEditor : VariableEditor<int>
    {
        protected override void AssignResetValue()
        {
            resetValue.intValue = value.intValue;
        }
    }
}