using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RocketSystem;

namespace Core
{
    namespace LookersSystem
    {
        public class GameOverLooker : MonoBehaviour
        {
            public Rocket_Stats stats { private get; set; }
            [SerializeField] private GameObject GameOverScreen;
            [SerializeField] private GameObject IntelligenceEndingScreen;
            [SerializeField] private GameObject PowerEndingScreen;
            [SerializeField] private GameObject CultureEndingScreen;
            [SerializeField] private GameObject MoneyEndingScreen;

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
    }
}