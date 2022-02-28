using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace Piano
{
    [Serializable]
    public class KeyImages : ISerializationCallbackReceiver
    {
        [SerializeField] private Image c;
        [SerializeField, Rename("C#")] private Image cSharp;
        [SerializeField] private Image d;
        [SerializeField, Rename("D#")] private Image dSharp;
        [SerializeField] private Image e;
        [SerializeField] private Image f;
        [SerializeField, Rename("F#")] private Image fSharp;
        [SerializeField] private Image g;
        [SerializeField, Rename("G#")] private Image gSharp;
        [SerializeField] private Image a;
        [SerializeField, Rename("A#")] private Image aSharp;
        [SerializeField] private Image b;
    
        private Dictionary<KeyName, Image> mapping;
    
        public Image this[KeyName key]
        {
            get => mapping[key];
        }
    
        public void OnAfterDeserialize()
        {
            mapping = new Dictionary<KeyName, Image>
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
