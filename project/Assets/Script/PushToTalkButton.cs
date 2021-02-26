using UnityEngine;
using UnityEngine.UI;

public class PushToTalkButton:  Button
{
    public static bool mouseDown = false;
    void Update()
    {
    }
    public void toogle()
    {
        mouseDown = !mouseDown;
        if (mouseDown)
        {
            OnPointerDown();
        }
        else
        {
            OnPointerUp();
        }
    }
    void OnPointerDown()
    {
        AuviisSDK.Auviis_unmuteSend();
        Debug.Log("down");
    }
    void OnPointerUp()
    {
        AuviisSDK.Auviis_muteSend();
        Debug.Log("up");
    }
}