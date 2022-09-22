using UnityEngine;
using System;
using UnityEngine.Audio;

namespace Minigioco2 { 
    public class AudioManager : MonoBehaviour
    {
        // Utilizza le caratteristiche della classe sound che ci consente di inserire varie info per i nostri suoni
        public Sound[] sounds;

        void Awake()
        {
            foreach (Sound s in sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;

                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
            }
        }

        void Start()
        {
            Play("Background");
        }

        public void Play(string name)
        {
            Sound s = Array.Find(sounds, sound => sound.name == name);
            if (s == null)
            {
                Debug.LogWarning("Sound: " + name + "not found!")
    ; return;
            }
            s.source.Play();
        }
    }
}
