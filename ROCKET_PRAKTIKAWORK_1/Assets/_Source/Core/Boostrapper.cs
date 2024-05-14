using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boostrapper : MonoBehaviour
{
    [SerializeField] public TMP_Text text_replica;
    [SerializeField] public CrewMember _crewmember;
    [SerializeField] public Rocket_Stats rocket;
    [SerializeField] public List<CharacterData> characterDatas = new List<CharacterData>();
    [SerializeField] public List<CharacterData> eventCharacterDatas = new List<CharacterData>();
    [SerializeField] public List<string> Names = new List<string>();
    [SerializeField] public List<string> Surnames = new List<string>();
    void Awake()
    {
        _crewmember.text_replica = text_replica;
        _crewmember.rocket = rocket;
        foreach (var data in characterDatas)
        {
            _crewmember.characterDatas.Add(data);
        }

        foreach (var data in eventCharacterDatas)
        {
            _crewmember.eventCharacterDatas.Add(data);
        }

        foreach (var name in Names)
        {
            _crewmember.Names.Add(name);
        }

        foreach (var surname in Surnames)
        {
            _crewmember.Surnames.Add(surname);
        }
    }
}
