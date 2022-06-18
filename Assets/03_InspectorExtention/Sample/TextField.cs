using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class TextField : MonoBehaviour
    {
        public string text;
        public string text2;
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(TextField))]
    public class TextFieldEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            TextField myTarget = (TextField)target;
            //DrawDefaultInspector();
            myTarget.text = EditorGUILayout.TextField(myTarget.text);
            myTarget.text2 = EditorGUILayout.TextField("ラベル", myTarget.text2);
        }
    }
#endif
