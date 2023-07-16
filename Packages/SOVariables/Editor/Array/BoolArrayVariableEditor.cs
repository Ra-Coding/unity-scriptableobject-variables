using UnityEditor;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(BoolArrayMutableVariable), editorForChildClasses: true)]
    public class BoolArrayVariableEditor : ArrayVariableEditor<bool[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).boolValue = value.GetArrayElementAtIndex(index).boolValue;
        }
    }
}
