using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    public class VariableWindow : EditorWindow
    {
        private static readonly string TAB = "    ";
        private static readonly string PACKAGE_NAMESPACE = "RaCoding.Variables";
        private static readonly string IMMUTABLEVARIABLE_CLASS_SUFFIX = "ImmutableVariable";
        private static readonly string MUTABLEVARIABLE_CLASS_SUFFIX = "MutableVariable";
        private static readonly string MUTABLEVARIABLEREFERENCE_CLASS_SUFFIX = "MutableVariableReference";
        private static readonly string VARIABLEEDITOR_CLASS_SUFFIX = "VariableEditor";

        private string _newNamespace = "RaCoding.Variables";
        private string _newType = "Sprite";
        private string _newTypeNamespace = "UnityEngine";
        private bool _isArray = false;

        private bool _groupEnabled;
        private bool _overrideExistingFiles = false;

        [MenuItem("Window/RaCoding/SO Variable Creator")]
        static void Init()
        {
            // Get existing open window or if none, make a new one:
            var window = (VariableWindow)EditorWindow.GetWindow(typeof(VariableWindow));
            window.Show();
        }

        void OnGUI()
        {
            GUILayout.Label("Base Settings", EditorStyles.boldLabel);
            _newNamespace = EditorGUILayout.TextField("Namespace", _newNamespace);
            _newType = EditorGUILayout.TextField("Type", _newType);
            _newTypeNamespace = EditorGUILayout.TextField("Type Namespace", _newTypeNamespace);
            _isArray = EditorGUILayout.Toggle("Is Array", _isArray);

            _groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", _groupEnabled);
            _overrideExistingFiles = EditorGUILayout.Toggle("Override existing files", _overrideExistingFiles);
            EditorGUILayout.EndToggleGroup();

            GUILayout.Space(10);

            if (GUILayout.Button("Generate"))
            {
                GenerateScripts();
            }
        }

        private string GenerateClassNames(string suffix, bool isArray)
        {
            if (string.IsNullOrEmpty(_newType))
            {
                throw new ArgumentException("Type can not be null or empty!");
            }

            string className = _newType.First().ToString().ToUpper() + _newType[1..];

            if (isArray)
            {
                return className + "Array" + suffix;
            }
            else
            {
                return className + suffix;

            }
        }

        private string GenerateVariableNamesPrefix(string type, bool isArray)
        {
            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentException("Type can not be null or empty!");
            }
            
            string variablePrefix = type.First().ToString().ToLower() + type[1..];

            if (isArray)
            {
                return variablePrefix + "Array";
            }
            else
            {
                return variablePrefix;

            }
        }

        private string GenerateClassPath(string className)
        {
            return "Assets/" + className + ".cs";
        }

        private void GenerateScripts()
        {
            Debug.Log("Generating scripts...");

            // class names
            string immutableVariableClassName = GenerateClassNames(IMMUTABLEVARIABLE_CLASS_SUFFIX, _isArray);
            string mutableVariableClassName = GenerateClassNames(MUTABLEVARIABLE_CLASS_SUFFIX, _isArray);
            string mutableVariableReferenceClassName = GenerateClassNames(MUTABLEVARIABLEREFERENCE_CLASS_SUFFIX, _isArray);
            string variableEditorClassName = GenerateClassNames(VARIABLEEDITOR_CLASS_SUFFIX, _isArray);

            // class paths
            string immutableVariableClassPath = GenerateClassPath(immutableVariableClassName);
            string mutableVariableClassPath = GenerateClassPath(mutableVariableClassName);
            string mutableVariableReferenceClassPath = GenerateClassPath(mutableVariableReferenceClassName);
            string variableEditorClassPath = GenerateClassPath(variableEditorClassName);

            if (CheckFilesGeneration(new string[] {immutableVariableClassPath, mutableVariableClassPath,
                                    mutableVariableReferenceClassPath, variableEditorClassPath}))
            {
                string type = _newType;
                if (_isArray)
                {
                    type += "[]";
                }

                GenerateImmutableVariable(immutableVariableClassName, type, immutableVariableClassPath);
                GenerateMutableVariable(mutableVariableClassName, type, mutableVariableClassPath);
                GenerateMutableVariableReference(mutableVariableReferenceClassName, type, GenerateVariableNamesPrefix(_newType, _isArray), mutableVariableClassName, mutableVariableReferenceClassPath);
                GenerateVariableEditor(variableEditorClassName, type, mutableVariableClassName, variableEditorClassPath, _isArray);
            }
            else
            {
                Debug.LogError("Could not generate files because they already exist!");
            }

            AssetDatabase.Refresh();
        }

        // returns true if files can be generated
        private bool CheckFilesGeneration(string[] classPath)
        {
            bool doesFileExist;
            for (int i = 0; i < classPath.Length; i++)
            {
                doesFileExist = File.Exists(classPath[i]);
                if (doesFileExist == true && _overrideExistingFiles == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void GenerateImmutableVariable(string className, string type, string classPath)
        {
            Debug.Log("Writing ImmutableVariable classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.Variables;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[CreateAssetMenu(fileName = \"" + className + "\"," +
                " menuName = \"RaCoding/Variables/Immutable/" + AddArrayPath(_isArray) + " Create new immutable " + type + " variable\")]");
            outfile.WriteLine(TAB + "public class " + className + " : ImmutableVariable<" + type + "> {}");
            outfile.WriteLine("}");
        }

        private void GenerateMutableVariable(string className, string type, string classPath)
        {
            Debug.Log("Writing MutableVariable classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.Variables;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[CreateAssetMenu(fileName = \"" + className + "\"," +
                " menuName = \"RaCoding/Variables/Mutable/" + AddArrayPath(_isArray) + "Create new mutable " + type + " variable\")]");
            outfile.WriteLine(TAB + "public class " + className + " : MutableVariable<" + type + "> {}");
            outfile.WriteLine("}");
        }

        private void GenerateMutableVariableReference(string className, string type, string variableNamePrefix, 
                                                    string mutableVariableClassName, string classPath)
        {
            Debug.Log("Writing MutableVariableReference classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.Variables;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[System.Serializable]");
            outfile.WriteLine(TAB + "public class " + className + " : MutableVariableReference<" + type + ">");
            outfile.WriteLine(TAB + "{");
            outfile.WriteLine(TAB + TAB + "[SerializeField] private " + mutableVariableClassName + " " + variableNamePrefix + "MutableVariable;");
            outfile.WriteLine("");
            outfile.WriteLine(TAB + TAB + "protected override MutableVariable<" + type + "> Reference => " + variableNamePrefix + "MutableVariable; ");
            outfile.WriteLine(TAB + "}");
            outfile.WriteLine("}");
        }
        private void GenerateVariableEditor(string className, string type, string mutableVariableClassName,
                                            string classPath, bool isArray)
        {
            Debug.Log("Writing VariableEditor classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEditor;");
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.Variables;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[CustomEditor(typeof(" + mutableVariableClassName + "), editorForChildClasses: true)]");

            if (isArray)
            {
                outfile.WriteLine(TAB + "public class " + className + " : ArrayVariableEditor<" + type + ">");
                outfile.WriteLine(TAB + "{");
                outfile.WriteLine(TAB + TAB + "protected override void AssignResetArrayElementValue(int index)");
                outfile.WriteLine(TAB + TAB + "{");
                outfile.WriteLine(TAB + TAB + TAB + "resetValue.GetArrayElementAtIndex(index).objectReferenceValue = value.GetArrayElementAtIndex(index).objectReferenceValue;");
                outfile.WriteLine(TAB + TAB + "}");
                outfile.WriteLine(TAB + "}");
            }
            else
            {
                outfile.WriteLine(TAB + "public class " + className + " : VariableEditor<" + type + ">");
                outfile.WriteLine(TAB + "{");
                outfile.WriteLine(TAB + TAB + "protected override void AssignResetValue()");
                outfile.WriteLine(TAB + TAB + "{");
                outfile.WriteLine(TAB + TAB + TAB + "resetValue.objectReferenceValue = value.objectReferenceValue;");
                outfile.WriteLine(TAB + TAB + "}");
                outfile.WriteLine(TAB + "}");
            }
            outfile.WriteLine("}");
        }

        private string AddArrayPath(bool isArray)
        {
            if (isArray)
            {
                return "Array/";
            }
            return "";
        }
    }
}