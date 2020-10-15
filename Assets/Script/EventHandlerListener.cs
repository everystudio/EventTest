using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandlerListener : MonoBehaviour
{
    public EventHandlerSender m_eventHandlerSender;
    private void OnEnable()
    {
        m_eventHandlerSender.EventVoid += ListenVoid;
        m_eventHandlerSender.EventInt += ListenInt;

    }

    private void OnDisable()
    {
        m_eventHandlerSender.EventVoid -= ListenVoid;
        m_eventHandlerSender.EventInt -= ListenInt;
    }

    public void ListenVoid(object _sender , System.EventArgs _arg )
    {
        Debug.Log("EventHandlerListener.ListenVoid");
    }
    public void ListenInt(object _sender , int _iArg)
    {
        Debug.Log(string.Format("EventHandlerListener.ListenInt({0})", _iArg));
    }

}
