using System;
using System.Runtime.InteropServices;

public class AuviisSDK
{
#if !UNITY_EDITOR && UNITY_IPHONE
        const string LUADLL = "__Internal";
#else
    const string LUADLL = "Auviis";
#endif
    /*
     Set Unity callbask to communicate with SDK.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_setUnityCallbacks();
    /*
     After connected to server successfully, the application will be assigned an unique identify, used to communicate to server.
     It can be seen as unique member of the session, and will be changed each time of connection.
     */
    [DllImport(LUADLL)]
    public static extern Int64 Auviis_getUniqueId();
    /*
     If you want to create a new room, to can use this API to get a new voice channel, and then tell other room members to join to (you are also).
     */
    [DllImport(LUADLL)]
    public static extern Int64 Auviis_createRandomChannel();
    /*
    Only one voice chat channel is avaiable at one time. Use this function to switch between active voice channel.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_setActiveVoiceChannel(Int64 channel_id);
    /*
     Auviis is not only send voice stream but also send text message
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_sendTextChat(Int64 channel_id, string msg);
    /*
     Please not use with this release
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_recordVoice();
    /*
     Please not use with this release
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_playRecord();
    /*
     Please not use with this release
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_stopRecord();
    /*
     Please not use with this release
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_sendVoiceChat(Int64 channel_id);
    /*
     Please not use with this release
     */
    [DllImport(LUADLL)]
    public static extern string Auviis_getRecordId();
    /*
     Please not use with this release
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_playVoiceMessage(string msg_id);
    /*
     Setup application id and signature, it is provided when user register an application
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_init(string id, string signature);
    /*
     Start the connection session to community server
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_default_connect();
    /*
     Start the connection session to dedicated server. Only use for enterprise users.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_connect(string server_address, UInt32 port, bool ssl = false);
    /*
     Close the session
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_disconnect();
    /*
     Stop send/receive any data to/from server
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_stop();
    /*
     Check the session is ready
     */
    [DllImport(LUADLL)]
    public static extern bool Auviis_ready();
    /*
     Join to a channel before can send any voice/text stream
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_joinChannel(Int64 channel_id);
    /*
     Leave a channel
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_leaveChannel(Int64 channel_id);
    /**
      Channel members
     */
    //    int64_t* Auviis_getChannelMembers(int64_t channel_id);
    /*
     Send text chat to active channel
     */
    //    void Auviis_sendTextChat(const char* text);
    /*
     Start to send and receive voice stream. The audio stream is only enable after use this function.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_startVoiceStream();
    /*
     Stop send/receive any voice stream.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_stopVoiceStream();
    /*
     Check if voice stream is enable
     */
    [DllImport(LUADLL)]
    public static extern bool Auviis_isVoiceStreamEnable();
    /*
     Stop send voice stream, but can receive from others
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_muteSend();
    /*
     Start to send voice stream if it is currently stopped.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_unmuteSend();
    /*
     Set output to  headset
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_outputToDefault();
    /*
     Set output to speaker
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_outputToSpeaker();
    /*
     Set output to bluetooth device, maybe it is not work at this release.
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_outputToBluetooth();
    //Audio
    /*
     Check if the inout and output audio devices are already initialized.
     */
    [DllImport(LUADLL)]
    public static extern bool Auviis_audioReady();
    /*
     This feature does not work in this release.
     */
    //    void Auviis_setLocalLoop(bool loop);
    /*
     Enable the input and output audio devices
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_enableAudio();
    /*
     Disable the input and output audio devices
     */
    [DllImport(LUADLL)]
    public static extern void Auviis_disableAudio();

    public AuviisSDK()
    {
    }
}
