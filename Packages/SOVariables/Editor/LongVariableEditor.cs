using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(LongMutableVariable), editorForChildClasses: true)]
    public class LongVariableEditor : VariableEditor<long>
    {
        protected override void AssignResetValue()
        {
            resetValue.longValue = value.longValue;
        }
    }
}