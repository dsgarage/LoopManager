using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

    public class TextArea : MonoBehaviour
    {
        public string text;
        public string text2;
    }
    #if UNITY_EDITOR
    [CustomEditor(typeof(TextArea))]
    public class TextAreaEditor : Editor
    {
        public GUI gUI = new GUI();
        public Vector2 scrollPosition;
        public override void OnInspectorGUI()
        {
            TextArea myTarget = (TextArea)target;
            //DrawDefaultInspector();
            
            //高さ120pxの入力欄
            myTarget.text = EditorGUILayout.TextArea(myTarget.text,GUILayout.Height(120f));
            
            //スクロール可能な入力欄(テキストの自動折り返しなし)
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, 
                //水平スクロールバーははみ出した場合に表示、垂直スクロールバーを常に表示
                //alwayShowHorizontal = false, alwayShowVertical = true
                false,true,
                //レイアウトの幅、高さ
                GUILayout.Width(240f),
                GUILayout.Height(120f)
                );
            myTarget.text2 = EditorGUILayout.TextArea(
                myTarget.text2,                 
                //幅が240を超えないように指定
                GUILayout.MaxWidth(240f)
                );
            EditorGUILayout.EndScrollView();

            //スクロール可能な入力欄(テキストの自動折り返しあり)
            //テキストエリアのスタイルを作成
            GUIStyle textAreaStyle = new GUIStyle(EditorStyles.textArea){
                //折り返しを有効にします
                wordWrap = true
            };
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, 
                //水平スクロールバーははみ出した場合に表示、垂直スクロールバーを常に表示
                //alwayShowHorizontal = false, alwayShowVertical = true
                false,true,
                //レイアウトの幅、高さ
                GUILayout.Width(240f),
                GUILayout.Height(120f)
                );
            myTarget.text2 = EditorGUILayout.TextArea(
                myTarget.text2,
                //作成したtextAreaStyleを適用
                textAreaStyle,              
                //幅が240を超えないように指定
                GUILayout.MaxWidth(240f)
                );
            EditorGUILayout.EndScrollView();
        }
    }
    #endif
