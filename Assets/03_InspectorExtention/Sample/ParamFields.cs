using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class ParamFields : MonoBehaviour
    {
        public int i, i1, i2, i3;
        public long l;
        public float f, f1, f2, f3;
        public double d;
        public Vector2 vector2 = new Vector2();
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(ParamFields))]
    public class ParamFieldsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            ParamFields myTarget = (ParamFields)target;
            //DrawDefaultInspector();
            //int関連の入力
            myTarget.i = EditorGUILayout.IntField(myTarget.i);
            myTarget.i1 = EditorGUILayout.IntField("i1", myTarget.i1);
            myTarget.i2 = EditorGUILayout.IntSlider(myTarget.i2, 5, 15);
            myTarget.i3 = EditorGUILayout.IntSlider("i3", myTarget.i3, 0, 5);
            //long関連の入力
            myTarget.l = EditorGUILayout.LongField(myTarget.l);
            //float関連の入力
            myTarget.f = EditorGUILayout.FloatField(myTarget.f);
            myTarget.f1 = EditorGUILayout.FloatField("f1", myTarget.f1);
            myTarget.f2 = EditorGUILayout.Slider(myTarget.f2, 5f, 15f);
            myTarget.f3 = EditorGUILayout.Slider("f3", myTarget.f3, 0f, 5f);
            //double関連の入力
            myTarget.d = EditorGUILayout.DoubleField(myTarget.d);
            //Vector2関連の入力
            myTarget.vector2 = EditorGUILayout.Vector2Field(new GUIContent("接点t", "ぉーん"), myTarget.vector2);
        }
    }
#endif
