using UnityEngine;
using UnityEditor;

public class ButtonSample : MonoBehaviour
{
    [SerializeField]
    private int buttonVar = 0;
    public void AddValu(int valu)
    {
        buttonVar += valu;
    }
}

[CustomEditor(typeof(ButtonSample))]
public class ButtonSampleEditor : Editor
{
    //OnInspectorGUIでカスタマイズのGUIに変更する
    public override void OnInspectorGUI()
    {
        //元のInspector部分を表示する
        base.OnInspectorGUI();
 
        //元のInspector部分の下にボタンを表示
        if (GUILayout.Button("Button"))
        {
            ButtonSample _target = (ButtonSample) target;
            _target.AddValu(1);
            Debug.Log("ボタンを押したよ"); 
        }
    }
}
