using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetImportProcesserTextur : AssetPostprocessor
{
    public override int GetPostprocessOrder()
    {
        return base.GetPostprocessOrder();
    }
    
    private void OnPreprocessTexture()
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessTexture(Texture2D texture)
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessSprites(Texture2D texture, Sprite[] sprites)
    {
        throw new NotImplementedException();
    }
}
