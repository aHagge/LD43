using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;

    public Slider volume;

    private void Start()
    {
        Play("Menu");
    }
    // Use this for initialization

    public AudioMixer am;
    public void setvolume(float volume)
    {
        am.SetFloat("Volume", volume);
    }


    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.outputAudioMixerGroup = am.FindMatchingGroups("Master")[0];
            s.Source.clip = s.Clip;

            s.Source.volume = s.volume;
            s.Source.pitch = s.pitch;
            s.Source.loop = s.loop;
        }
        Play("Main");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Cant find sound!");
            return;
        }
        s.Source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Cant find sound!");
            return;
        }
        s.Source.Stop();
    }
}