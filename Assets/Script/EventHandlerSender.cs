using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Systemが必要
using System;

public class EventHandlerSender : MonoBehaviour
{
    public event EventHandler EventVoid;
    public event EventHandler<int> EventInt;

    public int m_iEventParamInt = 123;

    // ボタンから呼び出される
    public void OnPushVoid()
    {
        if(EventVoid != null)
        {
            EventVoid.Invoke(this, new EventArgs());
        }
    }

    // ボタンから呼び出される
    public void OnPushInt()
    {
        if( EventInt != null)
        {
            EventInt.Invoke(this, m_iEventParamInt);
        }
    }

}
