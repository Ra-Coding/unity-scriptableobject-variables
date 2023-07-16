using UnityEditor;
using UnityEngine;

namespace RaCoding.Variables
{
    [CustomEditor(typeof(GameObjectArrayMutableVariable), editorForChildClasses: true)]
    public class GameObjectArrayVariableEditor : ArrayVariableEditor<GameObject[]>
    {
        protected override void AssignResetArrayElementValue(int index)
        {
            resetValue.GetArrayElementAtIndex(index).objectReferenceValue = value.GetArrayElementAtIndex(index).objectReferenceValue;
        }
    }
}
