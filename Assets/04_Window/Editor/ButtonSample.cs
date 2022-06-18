using System;
using UnityEngine;
using UnityEditor;

public class ButtonSample : EditorWindow
{
    private string textFieldText;
    
    
    //メニューからウィンドウを表示
    [MenuItem("WindowSample/ButtonSample",priority = 12)]
    static void Open()
    {
        var ButtonSample = GetWindow<ButtonSample>();
        ButtonSample.titleContent = new GUIContent("オリジナルのウィンドウ");
    }

    private void OnGUI()
    {
        textFieldText = EditorGUILayout.TextField("文字を入力", textFieldText);
        
        if( GUILayout.Button( "ボタン" ) )
        {
            Debug.Log( textFieldText + "を入力したね？" );
        }
        //上の入力欄に入力された情報が表示されるが、ここで入力した文字はどこにも反映されない
        EditorGUILayout.LabelField(textFieldText);
    }
}

