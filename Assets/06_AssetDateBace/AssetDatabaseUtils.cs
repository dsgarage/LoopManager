using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class AssetDatabaseUtils
{
    public static T FindAsset<T>() where T : UnityEngine.Object
    {
        return FindAssets<T>().FirstOrDefault();
    }

    public static IEnumerable<T> FindAssets<T>() where T : UnityEngine.Object
    {
        return AssetDatabase
                .FindAssets( $"t:{typeof( T ).Name}" )
                .Select( c => AssetDatabase.GUIDToAssetPath( c ) )
                .Select( c => AssetDatabase.LoadAssetAtPath<T>( c ) )
            ;
    }
}