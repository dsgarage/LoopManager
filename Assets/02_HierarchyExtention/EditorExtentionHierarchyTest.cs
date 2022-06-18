using UnityEditor;
using UnityEngine;

public class EditorExtentionHierarchyTest : MonoBehaviour
{
    [MenuItem("Sample/MenuItem")]
    public static void SampelMenuItem()
    {
        Debug.Log( "SampleMenuItem" );
    }
    
    [MenuItem("GameObject/MenuItem", priority = 21)]
    public static void GameObjectMenuItem()
    {
        Debug.Log( "GameObjectMenuItem" );
    }
}
