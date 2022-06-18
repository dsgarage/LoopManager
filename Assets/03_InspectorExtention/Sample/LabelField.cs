using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class LabelField : MonoBehaviour
    {
        public int i;
        public string str;
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(LabelField))]
    public class LabelFieldEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            //LabelField myTarget = (LabelField)target;
            EditorGUILayout.LabelField("デフォルトインスペクター");
            DrawDefaultInspector();
        }
    }
#endif
