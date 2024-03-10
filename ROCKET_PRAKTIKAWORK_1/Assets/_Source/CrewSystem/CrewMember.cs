using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CrewMember : MonoBehaviour
{
    [SerializeField] public Boostrapper _boostrapper;
    private TMP_Text text_replica;
    private Rocket_Stats rocket;
    private List<CharacterData> characterDatas = new List<CharacterData>(); 
    public int dp { get; private set; } //Уровень интелекта населения.
    public int cp { get; private set; } //Уровень мощь населения.
    public int qp { get; private set; } //Уровень культурность населения.
    public int hp { get; private set; } //Уровень деньги населения.

    public Animator animator;

    void Start()
    {
        text_replica = _boostrapper.text_replica;
        rocket = _boostrapper.rocket;
        for (int i = 0; i < _boostrapper.characterDatas.Count; i++)
        {
            characterDatas.Add(_boostrapper.characterDatas[i]);
        }
        animator = GetComponent<Animator>();
        MoveCame();
    }

    void UpdateData()
    {
        int x = Random.Range(0, characterDatas.Count - 1);
        dp = characterDatas[x].Intelligence;
        cp = characterDatas[x].Power;
        qp = characterDatas[x].Culture;
        hp = characterDatas[x].Money;
        text_replica.text = characterDatas[x].replica;
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