using UnityEngine;
using UnityEditor;

public class WindowLayout : EditorWindow
{
    //メニューからウィンドウを表示
    [MenuItem("WindowSample/WindowLayout",priority =11)]
    public static void Open (){
        WindowLayout.GetWindow (typeof(WindowLayout));
    }

    private void OnGUI() {
        //最小最大サイズの設定
        minSize = EditorGUILayout.Vector2Field("最小サイズ", minSize);
        maxSize = EditorGUILayout.Vector2Field("最大サイズ", maxSize);
        
        //現在のサイズ設定
        var currentPosition = position; //現在のウインドウのポジション情報
        
        //ウインドウの再描画の代入を、UIの描画と合わせてまとめて処理
        currentPosition.size = EditorGUILayout.Vector2Field("現在のサイズ", currentPosition.size);
        
        position = currentPosition;
    }
}
