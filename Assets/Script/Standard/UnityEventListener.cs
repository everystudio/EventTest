using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventListener : MonoBehaviour
{
    public UnityEventSender m_unityEventSender;

    private void OnEnable()
    {
        m_unityEventSender.EventVoid.AddListener(CallVoid);
        m_unityEventSender.EventInt.AddListener(CallInt);
    }
    private void OnDisable()
    {
        m_unityEventSender.EventVoid.RemoveListener(CallVoid);
        m_unityEventSender.EventInt.RemoveListener(CallInt);
    }
    private void CallVoid()
    {
        Debug.Log("UnityEventListener.CallVoid");
    }
    private void CallInt(int _iArg)
    {
        Debug.Log(string.Format("UnityEventListener.CallInt({0})", _iArg));
    }

}
