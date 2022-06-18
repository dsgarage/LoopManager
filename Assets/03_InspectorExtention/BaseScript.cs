using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class BaseScript : MonoBehaviour
{
    // 実態クラス
}

#if UNITY_EDITOR
[CustomEditor(typeof(BaseScript))]
public class BaseScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //元のInspector部分を表示する
        base.OnInspectorGUI();
        
        //対象のクラス情報を取得
        BaseScript myTarget = (BaseScript)target;
    }
}
#endif

