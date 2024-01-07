using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/String Event Channel")]
public class StringEventChannelSO : ScriptableObject
{
    public UnityAction<string> OnEventRaised;
    public void RaiseEvent(string value)
    {
        var fs = Resources.Load<StringEventChannelSO>($"EventSO/{name}");
        fs.OnEventRaised.Invoke(value);
    }
}