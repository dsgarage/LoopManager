using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class AssetInfoFacerd : ScriptableObject
{

    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // Unity プロジェクトに存在する Example アセットを取得する
        //var example = AssetDatabaseUtils.FindAsset<AudioClip>();

        // Unity プロジェクトに存在するすべての Example アセットを取得する
        var examples = AssetDatabaseUtils.FindAssets<AudioClip>();

        foreach (var VARIABLE in examples)
        {
            //Debug.Log(VARIABLE);
        }
    }
    
}
