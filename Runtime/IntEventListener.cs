using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntEventListener : MonoBehaviour
{
    public IntEventChannelSO StringGameEvent;
    public UnityEvent<int> OnEventRaised;

    void Awake()
    {
        StringGameEvent = Resources.Load<IntEventChannelSO>($"EventSO/{StringGameEvent.name}");
    }

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

    public void Respond(int str)
    {
        if (OnEventRaised == null)
        {
            return;
        }
        OnEventRaised.Invoke(str);
    }
}
