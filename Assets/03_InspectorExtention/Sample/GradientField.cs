using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class GradientField : MonoBehaviour
    {
        public Gradient gradient = new Gradient();
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(GradientField))]
    public class GradientFieldEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GradientField myTarget = (GradientField)target;
            //DrawDefaultInspector();

            /*public static Gradient GradientField (string label, Gradient value);*/
            myTarget.gradient = EditorGUILayout.GradientField(
                "Gradient",
                myTarget.gradient
            );
        }
    }
#endif

