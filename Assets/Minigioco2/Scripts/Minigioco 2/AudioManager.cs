﻿using UnityEngine;
using System;
using UnityEngine.Audio;

namespace Minigioco2 { 
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance;
 
        public Sound[] sounds;

        void Awake()
        {
            instance = this;
            foreach (Sound s in sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;

                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
            }
            Play("Background");
        }

        void Start()
        {
            
        }

        public void StopMusic()
        {
            Stop("Background");
            Play("GameOver");
        }

        public void Play(string name)
        {
            Sound s = Array.Find(sounds, sound => sound.name == name);
            if (s == null)
            {
                Debug.LogWarning("Sound: " + name + "not found!");
                return;
            }
            s.source.Play();
        }

        public void Stop(string name)
        {
            Sound s = Array.Find(sounds, sound => sound.name == name);
            if (s == null)
            {
                Debug.LogWarning("Sound: " + name + "not found!");
                return;
            }
            s.source.Stop();
        }
    }
}
