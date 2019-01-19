using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class AssetBundleManager : MonoBehaviour
{
    public static AssetBundleManager Instance;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AssetBundle LoadAssetBundle()
    {
        var filePath = Path.Combine(Application.dataPath, "AssetBundles", "level1");
        var ab = AssetBundle.LoadFromFile(filePath);
        return ab;
    }
}
