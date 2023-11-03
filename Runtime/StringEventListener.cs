using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StringEventListener : MonoBehaviour
{
    public StringEventChannelSO StringGameEvent;
    public UnityAction<string> OnEventRaised;

    private void OnEnable()
    {
        if (StringGameEvent == null)
        {
            return;
        }
        StringGameEvent.OnEventRaised += Respond;
    }

    private void OnDisable()
    {
        if (StringGameEvent == null)
        {
            return;
        }
        StringGameEvent.OnEventRaised -= Respond;
    }

    public void Respond(string str)
    {
        if (OnEventRaised == null)
        {
            return;
        }
        OnEventRaised.Invoke(str);
    }
}
