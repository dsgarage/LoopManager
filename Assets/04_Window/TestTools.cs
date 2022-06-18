using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
#endif

public class TestTools : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(TestTools))]
public class TestToolsWindow : Editor
{
    private TestTools _testTools;
    private VisualElement rootElement;
    private VisualTreeAsset visualTree;
 
    public override VisualElement CreateInspectorGUI()
    {
        _testTools = (TestTools)target;
        rootElement = new VisualElement();
 
        // 作成したUXMLデータ構造を読み込みます
        visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Test/TestTools.uxml");
      
        // スタイルシートデータを読み込みます(今回は作成していないのでコメントアウト)
        //StyleSheet stylesheet = AssetDatabase.LoadAssetAtPath("Assets/Editor/Test/TestTools.uss");
        //rootElement.styleSheets.Add(stylesheet);
 
        // 読み込んだツリー構造体をルートのUI要素としてクローン
        visualTree.CloneTree(rootElement);
 
        return rootElement;
    }
}
#endif
