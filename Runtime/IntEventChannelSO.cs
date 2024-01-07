using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Com.A9.EventSO
{
    [CreateAssetMenu(menuName = "Events/Int Event Channel")]
    public class IntEventChannelSO : ScriptableObject
    {
        public UnityAction<int> OnEventRaised;
        public void RaiseEvent(int value)
        {
            var fs = Resources.Load<IntEventChannelSO>($"EventSO/{name}");
            fs.OnEventRaised.Invoke(value);
        }
    }
}