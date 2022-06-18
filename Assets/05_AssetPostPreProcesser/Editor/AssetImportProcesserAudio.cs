using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetImportProcesserAudio : AssetPostprocessor
{
    public override int GetPostprocessOrder()
    {
        return base.GetPostprocessOrder();
    }

    private void OnPreprocessAudio()
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessAudio(AudioClip arg)
    {
        throw new NotImplementedException();
    }
}
