using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
    [SerializeField] public string replica { get; private set; }
    [SerializeField] public int Intelligence { get; private set; }
    [SerializeField] public int Power { get; private set; }
    [SerializeField] public int Culture { get; private set; }
    [SerializeField] public int Money { get; private set; }
}
