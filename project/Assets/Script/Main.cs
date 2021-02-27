using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Main : MonoBehaviour, AuviisSDKDelegate
{
    AuviisSDK auviisSDK;
    Text txtChatStatus;
    // Use this for initialization
    void Start () {
        auviisSDK = GameObject.Find("AuviisSDK").GetComponent<AuviisSDK>();

        txtChatStatus = GameObject.Find("TxtChatStatus").GetComponent<Text>();
        txtChatStatus.text = " Press start to begin";
        Button startBt = GameObject.Find("StartButton").GetComponent<Button>();
		startBt.onClick.AddListener(delegate () { StartSDK(); });
        Button stopBt = GameObject.Find("StopButton").GetComponent<Button>();
        stopBt.onClick.AddListener(delegate () { StopSDK(); });

    }
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartSDK()
	{
		Debug.Log("StartSDK");
        auviisSDK.setSDKDelegate(this);
#if !UNITY_EDITOR && UNITY_IPHONE
        AuviisSDK.Auviis_setUnityCallbacks();
		AuviisSDK.Auviis_init("6785JH889bhFGKU8904","PnHDEHHEIhjjAvcgQWUbcv");
		AuviisSDK.Auviis_default_connect();
        txtChatStatus.text = "AuviisSDK is connecting ...";
#endif
    }
    public void StopSDK()
    {
        Debug.Log("StopSDK");
#if !UNITY_EDITOR && UNITY_IPHONE
		AuviisSDK.Auviis_stop();
        txtChatStatus.text = "AuviisSDK is stopped";
#endif
    }

    void AuviisSDKDelegate.onAuviisSDKError(string reason)
    {
        Debug.Log("onAuviisSDKError");
        txtChatStatus.text = "AuviisSDK has error of connection.";
    }

    void AuviisSDKDelegate.onAuviisSDKDisconnect(string reason)
    {
        Debug.Log("onAuviisSDKDisconnect");
        txtChatStatus.text = "AuviisSDK is disconnected";
    }

    void AuviisSDKDelegate.onAuviisSDKInitSuccess(Int64 peer_id)
    {
        Debug.Log("onAuviisSDKInitSuccess");
        AuviisSDK.Auviis_startVoiceStream();
        txtChatStatus.text = "AuviisSDK init successfully.";
    }

    void AuviisSDKDelegate.onAuviisSDKActivated(Int64 peer_id)
    {
        Debug.Log("onAuviisSDKActivated");
        AuviisSDK.Auviis_joinChannel(123);
        txtChatStatus.text = "AuviisSDK  activated with peer id " + peer_id.ToString();
    }

    void AuviisSDKDelegate.onAuviisSDKJoinChannel(Int64 channel_id)
    {
        Debug.Log("onAuviisSDKJoinChannel");
        AuviisSDK.Auviis_setActiveVoiceChannel(channel_id);
        txtChatStatus.text = "AuviisSDK  joined channel " + channel_id.ToString();
    }
    void AuviisSDKDelegate.onAuviisSDKJoinChannel(Int64 channel_id, int members)
    {
        Debug.Log("onAuviisSDKJoinChannel");
        txtChatStatus.text = "AuviisSDK  joined channel " + channel_id.ToString() + " \nwith " + members.ToString() + " online members";
    }
}
