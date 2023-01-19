using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(SByteMutableVariable), editorForChildClasses: true)]
    public class SByteVariableEditor : VariableEditor<sbyte>
    {
        protected override void AssignResetValue()
        {
            resetValue.intValue = value.intValue;
        }
    }
}