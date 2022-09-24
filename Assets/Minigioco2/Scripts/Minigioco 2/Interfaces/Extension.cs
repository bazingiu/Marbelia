using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using System;
using UnityEngine.Audio;

namespace Minigioco2 { 
    public static class Extension
    {
        public static Sound getSound(string name, Sound[] sounds)
        {
            Sound s = Array.Find(sounds, sound => sound.name == name);
            if (s == null)
            {
                Debug.LogWarning("Sound: " + name + "not found!");
                return null;
            }
            return s;
        }
    }
}
