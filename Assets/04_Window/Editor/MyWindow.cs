using System;
using UnityEngine;
using UnityEditor;

public class MyWindow : EditorWindow
{
    //メニューからウィンドウを表示
    [MenuItem("WindowSample/MyWindow",priority = 10)]
    static void Open()
    {
        var window = GetWindow<MyWindow>();
        window.titleContent = new GUIContent("オリジナルのウィンドウ");
    }
}

