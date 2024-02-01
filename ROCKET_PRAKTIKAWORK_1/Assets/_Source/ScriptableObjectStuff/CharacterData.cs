using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
    [SerializeField] public string replica;
    //type character
    [SerializeField] public int dp;
    [SerializeField] public int cp;
    [SerializeField] public int qp;
    [SerializeField] public int hp;
}
