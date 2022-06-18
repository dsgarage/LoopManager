using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
    public class EditorButton : MonoBehaviour
    {
        
        public int score = 0;
        public void AddScore(int value){
            score += value;
        }
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(EditorButton))]
    public class EditorBubasettonEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            EditorButton myTarget = (EditorButton)target;
            //DrawDefaultInspector();
            if(GUILayout.Button("Button"))myTarget.AddScore(2);
        }
    }
#endif
