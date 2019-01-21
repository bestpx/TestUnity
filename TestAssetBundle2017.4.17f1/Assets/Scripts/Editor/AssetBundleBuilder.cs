using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class AssetBundleBuilder : MonoBehaviour
{
    [MenuItem("Tools/BuildAssetBundle")]
    public static void BuildAssetBundle()
    {
        var outputPath = Path.Combine(Application.dataPath, "AssetBundles");
        BuildPipeline.BuildAssetBundles(outputPath, 
            UnityEditor.BuildAssetBundleOptions.ForceRebuildAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }
}
