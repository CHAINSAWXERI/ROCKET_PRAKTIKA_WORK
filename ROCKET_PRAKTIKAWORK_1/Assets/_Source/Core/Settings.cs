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

    public void SetActiveMusic(bool Value)
    {
        audioSetings.MusicPlayed = Value;
        UpdateSettings();
    }

    public void SetActiveSound(bool Value)
    {
        audioSetings.SoundPlayed = Value;
        UpdateSettings();
    }

    private void UpdateSettings()
    {
        if (audioSetings.SoundPlayed == false)
        {
            SoundPlayer.volume = 0f;
        }
        else
        {
            SoundPlayer.volume = 1f;
        }

        if (audioSetings.MusicPlayed == false)
        {
            MusicPlayer.volume = 0f;
        }
        else
        {
            MusicPlayer.volume = 1f;
        }
    }
}
