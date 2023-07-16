using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(SpriteArrayMutableVariable), editorForChildClasses: true)]
    public class SpriteArrayVariableEditor : ArrayVariableEditor<Sprite[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).objectReferenceValue = value.GetArrayElementAtIndex(index).objectReferenceValue;
        }
    }
}
