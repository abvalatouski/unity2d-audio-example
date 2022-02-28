using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

namespace Piano
{
    public class KeyListener : MonoBehaviour
    {
        [SerializeField] private UnityEvent<KeyName> onKeyDown;
        [SerializeField] private UnityEvent<KeyName> onKeyUp;

        private Dictionary<EventType, UnityEvent<KeyName>> eventTypeMapping;
        private Dictionary<KeyCode, KeyName> keyCodeMapping;

        private void Awake()
        {
            eventTypeMapping = new Dictionary<EventType, UnityEvent<KeyName>>
            {
                { EventType.KeyDown, onKeyDown },
                { EventType.KeyUp, onKeyUp },
            };

            keyCodeMapping = new Dictionary<KeyCode, KeyName>
            {
                { KeyCode.Q, KeyName.C },
                { KeyCode.Alpha2, KeyName.CSharp },
                { KeyCode.W, KeyName.D },
                { KeyCode.Alpha3, KeyName.DSharp },
                { KeyCode.E, KeyName.E },
                { KeyCode.R, KeyName.F },
                { KeyCode.Alpha5, KeyName.FSharp },
                { KeyCode.T, KeyName.G },
                { KeyCode.Alpha6, KeyName.GSharp },
                { KeyCode.Y, KeyName.A },
                { KeyCode.Alpha7, KeyName.ASharp },
                { KeyCode.U, KeyName.B },
            };
        }

        private void OnGUI()
        {
            Event @event = Event.current;
            if (eventTypeMapping.TryGetValue(@event.type, out UnityEvent<KeyName> handler)
                && keyCodeMapping.TryGetValue(@event.keyCode, out KeyName key))
            {
                handler.Invoke(key);
            }
        }
    }
}
