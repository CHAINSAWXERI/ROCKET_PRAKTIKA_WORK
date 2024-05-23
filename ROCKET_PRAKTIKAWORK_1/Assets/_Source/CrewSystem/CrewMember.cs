using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using RocketSystem;

namespace CrewSystem
{
    public class CrewMember : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Animator animator;
        public TMP_Text text_replica { set; private get; }
        public TMP_Text NameOfMember { set; private get; }
        public Rocket_Stats rocket { set; private get; }

        public List<CharacterData> characterDatas { private set; get; } = new List<CharacterData>();
        public List<Sprite> SpriteCharacters { private set; get; } = new List<Sprite>();
        public List<string> Names { private set; get; } = new List<string>();
        public List<string> Surnames { private set; get; } = new List<string>();
        public List<EventCharacterData> eventCharacterDatas { private set; get; } = new List<EventCharacterData>();

        public int dp { get; private set; } //Уровень интелекта населения.
        public int cp { get; private set; } //Уровень мощь населения.
        public int qp { get; private set; } //Уровень культурность населения.
        public int hp { get; private set; } //Уровень деньги населения.

        private int CharacterCounter = 0;
        private int CharacterCounterTarget = 0;

        void Start()
        {
            CharacterCounterTarget = Random.Range(0, 31);
            MoveCame();
        }
        private void UpdateData()
        {
            if (CharacterCounter >= CharacterCounterTarget)
            {
                StartEvent();
            }
            else
            {
                int x = Random.Range(0, characterDatas.Count - 1);
                int spr = Random.Range(0, SpriteCharacters.Count - 1);
                int nm = Random.Range(0, Names.Count - 1);
                int srnm = Random.Range(0, Surnames.Count - 1);
                NameOfMember.text = Names[nm] + " " + Surnames[srnm];//
                dp = characterDatas[x].Intelligence;
                cp = characterDatas[x].Power;
                qp = characterDatas[x].Culture;
                hp = characterDatas[x].Money;
                text_replica.text = characterDatas[x].replica;
                _spriteRenderer.sprite = SpriteCharacters[spr];
                CharacterCounter++;
            }
        }

        private void StartEvent()
        {
            int x = Random.Range(0, eventCharacterDatas.Count - 1);
            NameOfMember.text = eventCharacterDatas[x].name;
            dp = eventCharacterDatas[x].Intelligence;
            cp = eventCharacterDatas[x].Power;
            qp = eventCharacterDatas[x].Culture;
            hp = eventCharacterDatas[x].Money;
            text_replica.text = eventCharacterDatas[x].replica;
            _spriteRenderer.sprite = eventCharacterDatas[x].sprite;
            CharacterCounter = 0;
            CharacterCounterTarget = Random.Range(0, 31);
        }

        public void MoveYes()
        {
            rocket.dp += dp;
            rocket.qp += qp;
            rocket.cp += cp;
            rocket.hp += hp;
            animator.SetInteger("ChangeAnim", 2);
        }

        public void MoveNo()
        {
            rocket.dp -= dp;
            rocket.qp -= qp;
            rocket.cp -= cp;
            rocket.hp -= hp;
            animator.SetInteger("ChangeAnim", 3);
        }

        public void MoveCame()
        {
            UpdateData();
            animator.SetInteger("ChangeAnim", 1);
        }
    }
}