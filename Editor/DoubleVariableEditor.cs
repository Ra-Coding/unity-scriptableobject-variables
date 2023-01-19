using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(DoubleMutableVariable), editorForChildClasses: true)]
    public class DoubleVariableEditor : VariableEditor<double>
    {
        protected override void AssignResetValue()
        {
            resetValue.doubleValue = value.doubleValue;
        }
    }
}