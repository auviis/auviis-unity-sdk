using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    PushToTalkButton pushToTalkBt;

    // Use this for initialization
    void Start () {
		Button startBt = GameObject.Find("StartButton").GetComponent<Button>();
		startBt.onClick.AddListener(delegate () { StartSDK(); });
        Button stopBt = GameObject.Find("StopButton").GetComponent<Button>();
        stopBt.onClick.AddListener(delegate () { StopSDK(); });

        pushToTalkBt = GameObject.Find("PushToTalkButton").GetComponent<PushToTalkButton>();
        pushToTalkBt.onClick.AddListener(delegate () { PushToTalkButton_Press(); });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartSDK()
	{
		Debug.Log("StartSDK");
#if !UNITY_EDITOR && UNITY_IPHONE
        AuviisSDK.Auviis_setUnityCallbacks();
		AuviisSDK.Auviis_init("6785JH889bhFGKU8904","PnHDEHHEIhjjAvcgQWUbcv");
		AuviisSDK.Auviis_default_connect();
#endif
    }
    public void StopSDK()
    {
        Debug.Log("StopSDK");
#if !UNITY_EDITOR && UNITY_IPHONE
		AuviisSDK.Auviis_stop();
#endif
    }
    public void PushToTalkButton_Press()
    {
        pushToTalkBt.toogle();
        Debug.Log("PushToTalkButton");
        
    }
  
}
