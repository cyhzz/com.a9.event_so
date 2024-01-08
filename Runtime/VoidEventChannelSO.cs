using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Com.A9.EventSO
{
    [CreateAssetMenu(menuName = "Events/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public UnityAction OnEventRaised;
        [ContextMenu("Raise")]
        public void RaiseEvent()
        {
            var fs = Resources.Load<VoidEventChannelSO>($"EventSO/{name}");

            if (fs.OnEventRaised == null)
            {
                Debug.LogWarning($"no so listener on {name}");
            }
            fs.OnEventRaised?.Invoke();
        }
    }
}
