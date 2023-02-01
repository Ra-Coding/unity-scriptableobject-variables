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

            _groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", _groupEnabled);
            _overrideExistingFiles = EditorGUILayout.Toggle("Override existing files", _overrideExistingFiles);
            EditorGUILayout.EndToggleGroup();

            GUILayout.Space(10);

            if (GUILayout.Button("Generate"))
            {
                GenerateScripts();
            }
        }

        private string GenerateClassNames(string suffix)
        {
            if (string.IsNullOrEmpty(_newType))
            {
                throw new ArgumentException("Type can not be null or empty!");
            }
            return _newType.First().ToString().ToUpper() + _newType[1..] + suffix;
        }

        private string GenerateVariableNamesPrefix()
        {
            if (string.IsNullOrEmpty(_newType))
            {
                throw new ArgumentException("Type can not be null or empty!");
            }
            return _newType.First().ToString().ToLower() + _newType[1..];
        }

        private string GenerateClassPath(string className)
        {
            return "Assets/" + className + ".cs";
        }

        private void GenerateScripts()
        {
            Debug.Log("Generating scripts...");

            // class names
            string immutableVariableClassName = GenerateClassNames(IMMUTABLEVARIABLE_CLASS_SUFFIX);
            string mutableVariableClassName = GenerateClassNames(MUTABLEVARIABLE_CLASS_SUFFIX);
            string mutableVariableReferenceClassName = GenerateClassNames(MUTABLEVARIABLEREFERENCE_CLASS_SUFFIX);
            string variableEditorClassName = GenerateClassNames(VARIABLEEDITOR_CLASS_SUFFIX);

            // class paths
            string immutableVariableClassPath = GenerateClassPath(immutableVariableClassName);
            string mutableVariableClassPath = GenerateClassPath(mutableVariableClassName);
            string mutableVariableReferenceClassPath = GenerateClassPath(mutableVariableReferenceClassName);
            string variableEditorClassPath = GenerateClassPath(variableEditorClassName);

            if (CheckFilesGeneration(new string[] {immutableVariableClassPath, mutableVariableClassPath,
                                    mutableVariableReferenceClassPath, variableEditorClassPath}))
            {
                GenerateImmutableVariable(immutableVariableClassName, immutableVariableClassPath);
                GenerateMutableVariable(mutableVariableClassName, mutableVariableClassPath);
                GenerateMutableVariableReference(mutableVariableReferenceClassName, GenerateVariableNamesPrefix(), mutableVariableClassName, mutableVariableReferenceClassPath);
                GenerateVariableEditor(variableEditorClassName, mutableVariableClassName, variableEditorClassPath);
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

        private void GenerateImmutableVariable(string className, string classPath)
        {
            Debug.Log("Writing ImmutableVariable classfile...");

            using (StreamWriter outfile = new(classPath))
            {
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
                    " menuName = \"RaCoding/Variables/Immutable/Create new immutable "+ _newType + " variable\")]");
                outfile.WriteLine(TAB + "public class " + className + " : ImmutableVariable<" + _newType + "> {}");
                outfile.WriteLine("}");
            }
        }

        private void GenerateMutableVariable(string className, string classPath)
        {
            Debug.Log("Writing MutableVariable classfile...");

            using (StreamWriter outfile = new(classPath))
            {
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
                    " menuName = \"RaCoding/Variables/Mutable/Create new mutable " + _newType + " variable\")]");
                outfile.WriteLine(TAB + "public class " + className + " : MutableVariable<" + _newType + "> {}");
                outfile.WriteLine("}");
            }
        }

        private void GenerateMutableVariableReference(string className, string variableNamePrefix, 
                                                    string mutableVariableClassName, string classPath)
        {
            Debug.Log("Writing MutableVariableReference classfile...");

            using (StreamWriter outfile = new(classPath))
            {
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
                outfile.WriteLine(TAB + "public class " + className + " : MutableVariableReference<" + _newType + ">");
                outfile.WriteLine(TAB + "{");
                outfile.WriteLine(TAB + TAB + "[SerializeField] private " + mutableVariableClassName + " " + variableNamePrefix + "MutableVariable;");
                outfile.WriteLine("");
                outfile.WriteLine(TAB + TAB + "protected override MutableVariable<" + _newType + "> Reference => " + variableNamePrefix + "MutableVariable; ");
                outfile.WriteLine(TAB + "}");
                outfile.WriteLine("}");
            }
        }
        private void GenerateVariableEditor(string className, string mutableVariableClassName,
                                            string classPath)
        {
            Debug.Log("Writing VariableEditor classfile...");

            using (StreamWriter outfile = new(classPath))
            {
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
                outfile.WriteLine(TAB + "[CustomEditor(typeof("+ mutableVariableClassName + "), editorForChildClasses: true)]");
                outfile.WriteLine(TAB + "public class " + className + " : VariableEditor<" + _newType + ">");
                outfile.WriteLine(TAB + "{");
                outfile.WriteLine(TAB + TAB + "protected override void AssignResetValue()");
                outfile.WriteLine(TAB + TAB + "{");
                outfile.WriteLine(TAB + TAB + TAB + "resetValue.objectReferenceValue = value.objectReferenceValue;");
                outfile.WriteLine(TAB + TAB + "}");
                outfile.WriteLine(TAB + "}");
                outfile.WriteLine("}");
            }
        }
    }
}