using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boostrapper : MonoBehaviour
{
    [SerializeField] public TMP_Text text_replica;
    [SerializeField] public Rocket_Stats rocket;
    [SerializeField] public List<CharacterData> characterDatas = new List<CharacterData>();
}
