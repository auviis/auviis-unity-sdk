using UnityEngine;
using UnityEngine.UI;

public class PushToTalkButton:  Button
{
    public static bool mouseDown = false;
    void Update()
    {
        if (IsPressed())
        {
            if (!mouseDown)
            {
                mouseDown = true;
                OnPointerDown();
            }
        }
        else
        {
            if (mouseDown)
            {
                mouseDown = false;
                OnPointerUp();
            }
        }
    }
    void OnPointerDown()
    {
    #if !UNITY_EDITOR && UNITY_IPHONE
        AuviisSDK.Auviis_unmuteSend();
    #endif
    }
    void OnPointerUp()
    {
#if !UNITY_EDITOR && UNITY_IPHONE
        AuviisSDK.Auviis_muteSend();
#endif
    }
}