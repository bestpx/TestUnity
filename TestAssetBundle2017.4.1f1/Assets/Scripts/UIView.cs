using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    public Image Background;
    public Image Title;
    public Image Button;

    // Start is called before the first frame update
    void Start()
    {
        var ab = AssetBundleManager.Instance.LoadAssetBundle();
        Background.sprite = ab.LoadAsset<Sprite>("background");
        Title.sprite = ab.LoadAsset<Sprite>("title");
        Button.sprite = ab.LoadAsset<Sprite>("button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
