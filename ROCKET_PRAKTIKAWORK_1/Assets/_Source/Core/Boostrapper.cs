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
    private void Start()
    {
        _crewmember.text_replica = text_replica;
        _crewmember.rocket = rocket;
        for (int i = 0; i < characterDatas.Count; i++)
        {
            _crewmember.characterDatas.Add(characterDatas[i]);
        }

        for (int i = 0; i < characterDatas.Count; i++)
        {
            _crewmember.eventCharacterDatas.Add(eventCharacterDatas[i]);
        }

        for (int i = 0; i < Names.Count; i++)
        {
            _crewmember.Names.Add(Names[i]);
        }

        for (int i = 0; i < Surnames.Count; i++)
        {
            _crewmember.Surnames.Add(Surnames[i]);
        }
    }
}
