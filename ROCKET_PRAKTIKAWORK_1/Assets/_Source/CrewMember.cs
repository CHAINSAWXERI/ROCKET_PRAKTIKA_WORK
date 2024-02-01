using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CrewMember : MonoBehaviour
{
    [SerializeField] public TMP_Text text_replica;
    [SerializeField] public Slider dp_slider;
    [SerializeField] public Slider cp_slider;
    [SerializeField] public Slider qp_slider;
    [SerializeField] public Slider hp_slider;

    [SerializeField] public List<CharacterData> characterDatas = new List<CharacterData>();
    //type character
    public int dp { get; private set; }
    public int cp { get; private set; }
    public int qp { get; private set; }
    public int hp { get; private set; }

    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MoveCame();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveYes();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            MoveNo();
        }
    }

    void UpdateData()
    {
        int x;
        x = Random.Range(0, characterDatas.Count - 1);
        dp = characterDatas[x].dp;
        cp = characterDatas[x].cp;
        qp = characterDatas[x].qp;
        hp = characterDatas[x].hp;
        text_replica.text = characterDatas[x].replica;
    }

    public void MoveYes()
    {
        animator.SetInteger("ChangeAnim", 2);
    }

    public void MoveNo()
    {
        animator.SetInteger("ChangeAnim", 3);
    }

    public void MoveCame()
    {
        animator.SetInteger("ChangeAnim", 1);
    }
}
/*
 * public float speed = 1.0f; // скорость перемещения

    void Update()
    {
        transform.Translate(Vector2.right  \*  speed  \*  Time.deltaTime); // перемещение по оси X в 2D пространстве
    }
 */
// -10.82