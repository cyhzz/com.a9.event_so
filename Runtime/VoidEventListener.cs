using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Com.A9.EventSO
{
    public class VoidEventListener : MonoBehaviour
    {
        public VoidEventChannelSO VoidGameEvent;
        public UnityEvent OnEventRaised;

        void Awake()
        {
            VoidGameEvent = Resources.Load<VoidEventChannelSO>($"EventSO/{VoidGameEvent.name}");
        }

        private void OnEnable()
        {
            if (VoidGameEvent == null)
            {
                return;
            }
            VoidGameEvent.OnEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (VoidGameEvent == null)
            {
                return;
            }
            VoidGameEvent.OnEventRaised -= Respond;
        }

        public void Respond()
        {
            if (OnEventRaised == null)
            {
                return;
            }
            OnEventRaised.Invoke();
        }
    }

}
