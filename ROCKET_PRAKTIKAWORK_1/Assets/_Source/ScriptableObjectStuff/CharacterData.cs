using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
    [SerializeField] public string replica;
    //type character
    [SerializeField] public int Intelligence;
    [SerializeField] public int Power;
    [SerializeField] public int Culture;
    [SerializeField] public int Money;
}
