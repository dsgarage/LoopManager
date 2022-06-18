using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class HelpBox : MonoBehaviour
    {
        public int i = 0;
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(HelpBox))]
    public class HelpBoxEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            //HelpBox myTarget = (HelpBox)target;

            EditorGUILayout.HelpBox("MsgBox",MessageType.None);
            DrawDefaultInspector();
            EditorGUILayout.HelpBox("InfoMsg",MessageType.Info);
            EditorGUILayout.HelpBox("WarningMsg",MessageType.Warning);
            EditorGUILayout.HelpBox("ErrorMsg",MessageType.Error);
        }
    }
#endif
