using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaySoundSystem
{
    public class OneShotPlaySound : MonoBehaviour
    {
        [SerializeField] public AudioSource audioSource;
        public void PlaySound(AudioClip playedSound)
        {
            audioSource.PlayOneShot(playedSound);
        }
    }
}