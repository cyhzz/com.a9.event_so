using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Com.A9.EventSO
{
    public class StringEventListener : MonoBehaviour
    {
        public StringEventChannelSO StringGameEvent;
        public UnityEvent<string> OnEventRaised;

        void Start()
        {
            StringGameEvent = Resources.Load<StringEventChannelSO>($"EventSO/{StringGameEvent.name}");
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

        public void Respond(string str)
        {
            if (OnEventRaised == null)
            {
                return;
            }
            OnEventRaised.Invoke(str);
        }
    }
}