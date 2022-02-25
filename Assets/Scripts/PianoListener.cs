using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

public class PianoListener : MonoBehaviour
{
    [SerializeField] UnityEvent<PianoKey> onKeyDown;
    [SerializeField] UnityEvent<PianoKey> onKeyUp;

    private Dictionary<EventType, UnityEvent<PianoKey>> eventTypeMapping;
    private Dictionary<KeyCode, PianoKey> keyCodeMapping;

    private void Awake()
    {
        eventTypeMapping = new Dictionary<EventType, UnityEvent<PianoKey>>
        {
            { EventType.KeyDown, onKeyDown },
            { EventType.KeyUp, onKeyUp },
        };

        keyCodeMapping = new Dictionary<KeyCode, PianoKey>
        {
            { KeyCode.Q, PianoKey.C },
            { KeyCode.Alpha2, PianoKey.CSharp },
            { KeyCode.W, PianoKey.D },
            { KeyCode.Alpha3, PianoKey.DSharp },
            { KeyCode.E, PianoKey.E },
            { KeyCode.R, PianoKey.F },
            { KeyCode.Alpha5, PianoKey.FSharp },
            { KeyCode.T, PianoKey.G },
            { KeyCode.Alpha6, PianoKey.GSharp },
            { KeyCode.Y, PianoKey.A },
            { KeyCode.Alpha7, PianoKey.ASharp },
            { KeyCode.U, PianoKey.B },
        };
    }

    private void OnGUI()
    {
        Event @event = Event.current;
        if (eventTypeMapping.TryGetValue(@event.type, out UnityEvent<PianoKey> handler)
            && keyCodeMapping.TryGetValue(@event.keyCode, out PianoKey key))
        {
            handler.Invoke(key);
        }
    }
}
