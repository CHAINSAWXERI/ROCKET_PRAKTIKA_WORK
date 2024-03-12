using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
    [SerializeField] public string replica;
    [SerializeField] public Sprite sprite;
    [SerializeField] public int Intelligence;  //Уровень интелекта населения.
    [SerializeField] public int Power;         //Уровень мощь населения.
    [SerializeField] public int Culture;       //Уровень культурность населения.
    [SerializeField] public int Money;         //Уровень деньги населения.
}
