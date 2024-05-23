using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using RocketSystem;
using CrewSystem;
using Core.LookersSystem;

namespace Core
{
    public class Boostrapper : MonoBehaviour
    {
        [SerializeField] public TMP_Text text_replica;
        [SerializeField] private TMP_Text NameOfMember;
        [SerializeField] public CrewMember _crewmember;
        [SerializeField] public Rocket_Stats rocket;
        [SerializeField] public GameOverLooker lookerGameOver;
        [SerializeField] public List<CharacterData> characterDatas = new List<CharacterData>();
        [SerializeField] public List<EventCharacterData> eventCharacterDatas = new List<EventCharacterData>();
        [SerializeField] public List<Sprite> spriteCharacter = new List<Sprite>();
        [SerializeField] public List<string> Names = new List<string>();
        [SerializeField] public List<string> Surnames = new List<string>();
        void Awake()
        {
            lookerGameOver.stats = rocket;

            _crewmember.text_replica = text_replica;
            _crewmember.NameOfMember = NameOfMember;
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

            foreach (var sprite in spriteCharacter)
            {
                _crewmember.SpriteCharacters.Add(sprite);
            }
        }
    }
}