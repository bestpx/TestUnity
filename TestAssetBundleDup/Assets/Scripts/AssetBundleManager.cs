using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class AssetBundleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadAsset()
    {

    }

    [MenuItem("Tools/BuildAssetBundle")]
    public static void BuildAssetBundle()
    {
        var outputPath = Path.Combine(Application.dataPath, "AssetBundles");
        BuildPipeline.BuildAssetBundles(outputPath, 
            UnityEditor.BuildAssetBundleOptions.ForceRebuildAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }
}
