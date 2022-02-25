using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PianoHandler : MonoBehaviour
{
    [SerializeField] Image keyC;
    [SerializeField] Image keyCSharp;
    [SerializeField] Image keyD;
    [SerializeField] Image keyDSharp;
    [SerializeField] Image keyE;
    [SerializeField] Image keyF;
    [SerializeField] Image keyFSharp;
    [SerializeField] Image keyG;
    [SerializeField] Image keyGSharp;
    [SerializeField] Image keyA;
    [SerializeField] Image keyASharp;
    [SerializeField] Image keyB;
    [Space]
    [SerializeField] AudioClip soundC;
    [SerializeField] AudioClip soundCSharp;
    [SerializeField] AudioClip soundD;
    [SerializeField] AudioClip soundDSharp;
    [SerializeField] AudioClip soundE;
    [SerializeField] AudioClip soundF;
    [SerializeField] AudioClip soundFSharp;
    [SerializeField] AudioClip soundG;
    [SerializeField] AudioClip soundGSharp;
    [SerializeField] AudioClip soundA;
    [SerializeField] AudioClip soundASharp;
    [SerializeField] AudioClip soundB;
    [Space]
    [SerializeField] AudioSource player;
    [SerializeField, Range(0F, 1F)] float volume;
    [Space]
    [SerializeField] Sprite whiteKeySprite;
    [SerializeField] Sprite blackKeySprite;
    [SerializeField] Sprite pressedWhiteKeySprite;
    [SerializeField] Sprite pressedBlackKeySprite;

    private Dictionary<PianoKey, Image> imageMapping;
    private Dictionary<PianoKey, AudioClip> audioClipMapping;

    private void Awake()
    {
        imageMapping = new Dictionary<PianoKey, Image>
        {
            { PianoKey.C, keyC },
            { PianoKey.CSharp, keyCSharp },
            { PianoKey.D, keyD },
            { PianoKey.DSharp, keyDSharp },
            { PianoKey.E, keyE },
            { PianoKey.F, keyF },
            { PianoKey.FSharp, keyFSharp },
            { PianoKey.G, keyG },
            { PianoKey.GSharp, keyGSharp },
            { PianoKey.A, keyA },
            { PianoKey.ASharp, keyASharp },
            { PianoKey.B, keyB },
        };

        audioClipMapping = new Dictionary<PianoKey, AudioClip>
        {
            { PianoKey.C, soundC },
            { PianoKey.CSharp, soundCSharp },
            { PianoKey.D, soundD },
            { PianoKey.DSharp, soundDSharp },
            { PianoKey.E, soundE },
            { PianoKey.F, soundF },
            { PianoKey.FSharp, soundFSharp },
            { PianoKey.G, soundG },
            { PianoKey.GSharp, soundGSharp },
            { PianoKey.A, soundA },
            { PianoKey.ASharp, soundASharp },
            { PianoKey.B, soundB },
        };

        player.volume = volume;
    }

    public void OnKeyDown(PianoKey key)
    {
        player.PlayOneShot(audioClipMapping[key]);
        imageMapping[key].sprite = key.IsSharp()
            ? pressedBlackKeySprite
            : pressedWhiteKeySprite;
    }

    public void OnKeyUp(PianoKey key)
    {
        imageMapping[key].sprite = key.IsSharp()
            ? blackKeySprite
            : whiteKeySprite;
    }
}
