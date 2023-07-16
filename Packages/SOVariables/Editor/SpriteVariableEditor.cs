using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(SpriteMutableVariable), editorForChildClasses: true)]
    public class SpriteVariableEditor : VariableEditor<Sprite>
    {
        protected override void AssignResetValue()
        {
            resetValue.objectReferenceValue = value.objectReferenceValue;
        }
    }
}
