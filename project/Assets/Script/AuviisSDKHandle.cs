using UnityEngine;
using System.Collections;

public class AuviisSDKHandle : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="reason"></param>
    void onError(string reason)
    {
        //TODO
    }

    void onDisconnect(string reason)
    {
        //TODO
    }


    void onInitSuccess(string peer_id)
    {
        //    updateChatContent(@"sdk init successfully");
        Debug.Log("AuviisSDK init successfully");
    }
    void onActivated(string peer_id)
    {
        Debug.Log("AuviisSDK has assigned your peer id of " + peer_id);
        AuviisSDK.Auviis_joinChannel(123);
    }
    void onJoinChannel(string channel_id)
    {
        AuviisSDK.Auviis_setActiveVoiceChannel(int.Parse(channel_id));
        AuviisSDK.Auviis_startVoiceStream();
        //    updateChatContent(@"sdk join successfully, enable voice stream");
        Debug.Log("AuviisSDK sdk join successfully, enable voice stream on " + channel_id);
    }
}
