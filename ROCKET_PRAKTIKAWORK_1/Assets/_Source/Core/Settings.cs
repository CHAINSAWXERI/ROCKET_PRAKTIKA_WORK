using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] public AudioSetingsSO audioSetings;
    [SerializeField] public AudioSource MusicPlayer;
    [SerializeField] public AudioSource SoundPlayer;

    void Start()
    {
        UpdateSettings();
    }

    public void SetNewValueMusic(float Value)
    {
        audioSetings.MusicPlayedValue = Value;
        UpdateSettings();
    }

    public void SetNewValueSound(float Value)
    {
        audioSetings.SoundPlayedValue = Value;
        UpdateSettings();
    }

    private void UpdateSettings()
    {
        SoundPlayer.volume = audioSetings.SoundPlayedValue;
        MusicPlayer.volume = audioSetings.MusicPlayedValue;
    }
}
