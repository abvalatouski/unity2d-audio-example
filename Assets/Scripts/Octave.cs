using System;
using System.Collections.Generic;

using UnityEngine;

namespace Piano
{
    [Serializable]
    public class Octave : ISerializationCallbackReceiver
    {
        [SerializeField] private AudioClip c;
        [SerializeField, Rename("C#")] private AudioClip cSharp;
        [SerializeField] private AudioClip d;
        [SerializeField, Rename("D#")] private AudioClip dSharp;
        [SerializeField] private AudioClip e;
        [SerializeField] private AudioClip f;
        [SerializeField, Rename("F#")] private AudioClip fSharp;
        [SerializeField] private AudioClip g;
        [SerializeField, Rename("G#")] private AudioClip gSharp;
        [SerializeField] private AudioClip a;
        [SerializeField, Rename("A#")] private AudioClip aSharp;
        [SerializeField] private AudioClip b;
    
        private Dictionary<KeyName, AudioClip> mapping;
    
        public AudioClip this[KeyName key]
        {
            get => mapping[key];
        }
    
        public void OnAfterDeserialize()
        {
            mapping = new Dictionary<KeyName, AudioClip>
            {
                { KeyName.C, c },
                { KeyName.CSharp, cSharp },
                { KeyName.D, d },
                { KeyName.DSharp, dSharp },
                { KeyName.E, e },
                { KeyName.F, f },
                { KeyName.FSharp, fSharp },
                { KeyName.G, g },
                { KeyName.GSharp, gSharp },
                { KeyName.A, a },
                { KeyName.ASharp, aSharp },
                { KeyName.B, b },
            };
        }

        public void OnBeforeSerialize()
        {
        }
    }
}
