using UnityEditor;

namespace RaCoding.Variables
{
    public abstract class VariableEditor<T> : Editor
    {
        protected SerializedProperty value;
        protected SerializedProperty resetValue;
    
        void OnEnable()
        {
            value = serializedObject.FindProperty("value");
            resetValue = serializedObject.FindProperty("resetValue");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(value);
            EditorGUILayout.PropertyField(resetValue);

            if (value.hasMultipleDifferentValues)
            {
                EditorGUILayout.HelpBox("Cannot assign multiple different values to resetValue.", MessageType.Info);
            }
            else
            {
                AssignResetValue();
            }

            serializedObject.ApplyModifiedProperties();
        }

        protected abstract void AssignResetValue();
    }
}