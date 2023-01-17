using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(FloatMutableVariable), editorForChildClasses: true)]
    public class FloatVariableEditor : VariableEditor<float>
    {
        protected override void AssignResetValue()
        {
            resetValue.floatValue = value.floatValue;
        }
    }
}