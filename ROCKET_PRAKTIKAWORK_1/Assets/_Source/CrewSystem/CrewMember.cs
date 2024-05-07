using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CrewMember : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private TMP_Text NameOfMember;
    public TMP_Text text_replica { set; private get; }
    public Rocket_Stats rocket { set; private get; }
    public List<CharacterData> characterDatas = new List<CharacterData>();
    public List<string> Names = new List<string>();
    public List<string> Surnames = new List<string>();
    public int dp { get; private set; } //Уровень интелекта населения.
    public int cp { get; private set; } //Уровень мощь населения.
    public int qp { get; private set; } //Уровень культурность населения.
    public int hp { get; private set; } //Уровень деньги населения.

    public List<CharacterData> eventCharacterDatas = new List<CharacterData>();

    public Animator animator;

    private int CharacterCounter = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        MoveCame();
    }

    private void UpdateData()
    {
        if (CharacterCounter >= 5)
        {
            StartEvent();
        }
        else
        {
            int x = Random.Range(0, characterDatas.Count - 1);
            int nm = Random.Range(0, Names.Count - 1);
            int srnm = Random.Range(0, Surnames.Count - 1);
            NameOfMember.text = Names[nm] + " " + Surnames[srnm];
            dp = characterDatas[x].Intelligence;
            cp = characterDatas[x].Power;
            qp = characterDatas[x].Culture;
            hp = characterDatas[x].Money;
            text_replica.text = characterDatas[x].replica;
            _spriteRenderer.sprite = characterDatas[x].sprite;
            CharacterCounter++;
        }
    }

    private void StartEvent()
    {
        int x = Random.Range(0, eventCharacterDatas.Count - 1);
        NameOfMember.text = "?????????????";
        dp = eventCharacterDatas[x].Intelligence;
        cp = eventCharacterDatas[x].Power;
        qp = eventCharacterDatas[x].Culture;
        hp = eventCharacterDatas[x].Money;
        text_replica.text = eventCharacterDatas[x].replica;
        _spriteRenderer.sprite = eventCharacterDatas[x].sprite;
        CharacterCounter = 0;
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