using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(GameObjectMutableVariable), editorForChildClasses: true)]
    public class GameObjectVariableEditor : VariableEditor<GameObject>
    {
        protected override void AssignResetValue()
        {
            resetValue.objectReferenceValue = value.objectReferenceValue;
        }
    }
}