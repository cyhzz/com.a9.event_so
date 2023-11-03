using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace A9.EventSO
{
    [CreateAssetMenu(menuName = "Events/String Event Channel")]
    public class StringEventChannelSO : ScriptableObject
    {
        public UnityAction<string> OnEventRaised;
        public void RaiseEvent(string value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}