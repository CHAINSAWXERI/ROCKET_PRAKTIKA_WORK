using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLooker : MonoBehaviour
{
    [SerializeField] Rocket_Stats stats;
    [SerializeField] GameObject GameOverScreen;

    void Update()
    {
        if ((stats.dp <= 0) | (stats.cp <= 0) | (stats.qp <= 0) | (stats.hp <= 0))
        {
            GameOverScreen.SetActive(true);
        }
    }
}
