using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLooker : MonoBehaviour
{
    [SerializeField] Rocket_Stats stats;
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] GameObject IntelligenceEndingScreen;
    [SerializeField] GameObject PowerEndingScreen;
    [SerializeField] GameObject CultureEndingScreen;
    [SerializeField] GameObject MoneyEndingScreen;

    void Update()
    {
        if ((stats.dp <= 0) | (stats.cp <= 0) | (stats.qp <= 0) | (stats.hp <= 0))
        {
            GameOverScreen.SetActive(true);
        }

        if (stats.dp >= stats.dp_slider.maxValue)
        {
            IntelligenceEndingScreen.SetActive(true);
        }

        if (stats.cp >= stats.cp_slider.maxValue)
        {
            PowerEndingScreen.SetActive(true);
        }

        if (stats.qp >= stats.qp_slider.maxValue)
        {
            CultureEndingScreen.SetActive(true);
        }

        if (stats.hp >= stats.hp_slider.maxValue)
        {
            MoneyEndingScreen.SetActive(true);
        }
    }
}
