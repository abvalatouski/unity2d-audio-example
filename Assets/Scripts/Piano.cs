using UnityEngine;

namespace Piano
{
    public class Piano : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private KeyImages images;
        [SerializeField] private Sprite whiteKeySprite;
        [SerializeField] private Sprite blackKeySprite;
        [SerializeField] private Sprite pressedWhiteKeySprite;
        [SerializeField] private Sprite pressedBlackKeySprite;
        [Header("Sound")]
        [Space]
        [SerializeField] private AudioSource player;
        [SerializeField, Range(0F, 1F)] private float volume;
        [SerializeField] private Octave octave;
    
        private void Awake()
        {
            player.volume = volume;
        }
    
        public void OnKeyDown(KeyName key)
        {
            player.PlayOneShot(octave[key]);
            images[key].sprite = key.IsSharp()
                ? pressedBlackKeySprite
                : pressedWhiteKeySprite;
        }
    
        public void OnKeyUp(KeyName key)
        {
            images[key].sprite = key.IsSharp()
                ? blackKeySprite
                : whiteKeySprite;
        }
    }
}
