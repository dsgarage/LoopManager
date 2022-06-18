using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetImportProcesserModel : AssetPostprocessor
{
    public override int GetPostprocessOrder()
    {
        return base.GetPostprocessOrder();
    }

    private void OnPreprocessModel()
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessModel(GameObject g)
    {
        throw new NotImplementedException();
    }
    
    private void OnPostprocessMaterial(Material material)
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessCubemap(Cubemap texture)
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessAnimation(GameObject root, AnimationClip clip)
    {
        throw new NotImplementedException();
    }

    private void OnPostprocessMeshHierarchy(GameObject root)
    {
        throw new NotImplementedException();
    }
}
