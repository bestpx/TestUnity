using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AssetBundleManager : MonoBehaviour
{
    public static AssetBundleManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public AssetBundle LoadAssetBundle()
    {
        var abPath = Path.Combine(Application.dataPath, "AssetBundles");
        var filePath = Path.Combine(abPath, "Level1");
        var ab = AssetBundle.LoadFromFile(filePath);
        return ab;
    }
}
