using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLooker : MonoBehaviour
{
    [SerializeField] Rocket_Stats stats;
    [SerializeField] GameObject GameOverScreen;

    void Update()
    {
        if (stats.dp <= 0)
        {
            GameOverScreen.SetActive(true);
        }
        if (stats.cp <= 0)
        {
            GameOverScreen.SetActive(true);
        }
        if (stats.qp <= 0)
        {
            GameOverScreen.SetActive(true);
        }
        if (stats.hp <= 0)
        {
            GameOverScreen.SetActive(true);
        }
    }
}
