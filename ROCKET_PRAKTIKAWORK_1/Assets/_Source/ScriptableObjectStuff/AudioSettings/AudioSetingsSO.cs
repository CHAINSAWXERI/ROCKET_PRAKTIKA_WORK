using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AudioSettings/AudioSettings", order = 1)]
public class AudioSetingsSO : ScriptableObject
{
    [field: SerializeField] public bool SoundPlayed;
    [field: SerializeField] public bool MusicPlayed;
}
