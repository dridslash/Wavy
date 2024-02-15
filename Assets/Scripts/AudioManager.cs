using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager Instance;


    // Awake is called before the Start
    void Awake() {

        if(Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else{
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds){
            s.audiosource = gameObject.AddComponent<AudioSource>();
            s.audiosource.clip = s.clip;
            s.audiosource.volume = s.Volume;
            s.audiosource.pitch = s.pitch;
            s.audiosource.loop = s.loop;
        }
    }

    void Start(){
        PlaySound("Theme");
    }

    // Update is called once per frame
    public void PlaySound(string soundname){
        Sound sound = Array.Find(sounds ,sound => sound.name == soundname);
        if(sound != null)
            sound.audiosource.Play();
    }

    public void StopSound(string soundname){
        Sound sound = Array.Find(sounds ,sound => sound.name == soundname);
        if(sound != null)
            sound.audiosource.Stop();
    }
}
