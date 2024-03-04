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
    //type character
    public int dp { get; private set; }
    public int cp { get; private set; }
    public int qp { get; private set; }
    public int hp { get; private set; }

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

    void Update()
    {

    }

    void UpdateData()
    {
        int x = Random.Range(0, characterDatas.Count - 1);
        dp = characterDatas[x].dp;
        cp = characterDatas[x].cp;
        qp = characterDatas[x].qp;
        hp = characterDatas[x].hp;
        text_replica.text = characterDatas[x].replica;
    }

    public void MoveYes()
    {
        rocket.dp += dp;
        rocket.qp += qp;
        rocket.cp += cp;
        rocket.hp += hp;
        animator.SetInteger("ChangeAnim", 2);
        //MoveCame();
    }

    public void MoveNo()
    {
        rocket.dp -= dp;
        rocket.qp -= qp;
        rocket.cp -= cp;
        rocket.hp -= hp;
        animator.SetInteger("ChangeAnim", 3);
        //MoveCame();
    }

    public void MoveCame()
    {
        UpdateData();
        animator.SetInteger("ChangeAnim", 1);
    }
}