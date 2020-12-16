using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UnityEngine.Eventsが必要
using UnityEngine.Events;

public class UnityEventSender : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent EventVoid = new UnityEvent();

    public class UnityEventInt : UnityEvent<int> {}
    public UnityEventInt EventInt = new UnityEventInt();

    public int m_iEventParamInt = 456;

    // ボタンから呼び出される
    public void OnPushVoid()
    {
        if( EventVoid != null)
        {
            EventVoid.Invoke();
        }
    }

    // ボタンから呼び出される
    public void OnPushInt()
    {
        if( EventInt != null)
        {
            EventInt.Invoke(m_iEventParamInt);
        }
    }

}
