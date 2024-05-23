using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
    [field:SerializeField] public string replica { get; private set; } 
    [field:SerializeField] public int Intelligence { get; private set; }  //Уровень интелекта населения.
    [field:SerializeField] public int Power { get; private set; }         //Уровень мощь населения.
    [field:SerializeField] public int Culture { get; private set; }       //Уровень культурность населения.
    [field:SerializeField] public int Money { get; private set; }         //Уровень деньги населения.
}
