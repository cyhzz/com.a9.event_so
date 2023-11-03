using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace A9.EventSO
{
    public class VoidEventListener : MonoBehaviour
    {
        public VoidEventChannelSO VoidGameEvent;
        public UnityEvent OnEventRaised;

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

