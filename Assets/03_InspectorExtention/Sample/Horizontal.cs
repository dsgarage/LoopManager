using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class Horizontal : MonoBehaviour
    {
        public int param = 10;
        public void AddParam(int value) => param += value ;
        public void SubParam(int value) => param -= value ;
        
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(Horizontal))]
    public class HorizontalEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            Horizontal myTarget = (Horizontal)target;
            //DrawDefaultInspector();
            myTarget.param = EditorGUILayout.IntField("param", myTarget.param);
            EditorGUILayout.BeginHorizontal();
            if(GUILayout.Button("Add"))myTarget.AddParam(1);
            if(GUILayout.Button("Sub"))myTarget.SubParam(1);
            EditorGUILayout.EndHorizontal();
        }
    }
#endif
