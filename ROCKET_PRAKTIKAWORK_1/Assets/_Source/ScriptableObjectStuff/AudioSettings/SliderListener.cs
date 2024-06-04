using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SliderListener : MonoBehaviour
{
    [SerializeField] public UnityEngine.UI.Slider soundSlider;
    [SerializeField] public UnityEngine.UI.Slider musicSlider;
    [SerializeField] public Settings settings;
    private float valueChangedThreshold = 0.001f;
    private float lastSoundValue;
    private float lastMusicValue;

    private void Start()
    {
        musicSlider.value = settings.audioSetings.MusicPlayedValue;
        soundSlider.value = settings.audioSetings.SoundPlayedValue;
        lastSoundValue = soundSlider.value;
        lastMusicValue = musicSlider.value;
    }

    private void Update()
    {
        if (Mathf.Abs(soundSlider.value - lastSoundValue) > valueChangedThreshold)
        {
            OnSoundValueChanged();
            lastSoundValue = soundSlider.value;
        }

        if (Mathf.Abs(musicSlider.value - lastMusicValue) > valueChangedThreshold)
        {
            OnMusicValueChanged();
            lastMusicValue = musicSlider.value;
        }
    }

    private void OnMusicValueChanged()
    {
        settings.SetNewValueMusic(musicSlider.value);
    }

    private void OnSoundValueChanged()
    {
        settings.SetNewValueSound(soundSlider.value);
    }
}
