using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RocketSystem;
using PlaySoundSystem;

namespace Core
{
    namespace LookersSystem
    {
        public class GameOverLooker : MonoBehaviour
        {
            public Rocket_Stats stats { private get; set; }
            [SerializeField] private OneShotPlaySound oneShotPlaySound;
            [SerializeField] private GameObject ost;
            [SerializeField] private GameObject GameOverScreen;
            [SerializeField] private AudioClip GameOverSound;
            [SerializeField] private GameObject IntelligenceEndingScreen;
            [SerializeField] private AudioClip IntelligenceEndingSound;
            [SerializeField] private GameObject PowerEndingScreen;
            [SerializeField] private AudioClip PowerEndingSound;
            [SerializeField] private GameObject CultureEndingScreen;
            [SerializeField] private AudioClip CultureEndingSound;
            [SerializeField] private GameObject MoneyEndingScreen;
            [SerializeField] private AudioClip MoneyEndingSound;
            private bool _alreadyplayed = false;

            void Update()
            {
                if (((stats.dp <= 0) | (stats.cp <= 0) | (stats.qp <= 0) | (stats.hp <= 0)) & _alreadyplayed == false)
                {
                    GameOverScreen.SetActive(true);
                    ost.SetActive(false);
                    oneShotPlaySound.PlaySound(GameOverSound);
                    _alreadyplayed = true;
                }

                if ((stats.dp >= stats.dp_slider.maxValue) & _alreadyplayed == false)
                {
                    IntelligenceEndingScreen.SetActive(true);
                    ost.SetActive(false);
                    oneShotPlaySound.PlaySound(IntelligenceEndingSound);
                    _alreadyplayed = true;
                }

                if ((stats.cp >= stats.cp_slider.maxValue) & _alreadyplayed == false)
                {
                    PowerEndingScreen.SetActive(true);
                    ost.SetActive(false);
                    oneShotPlaySound.PlaySound(PowerEndingSound);
                    _alreadyplayed = true;
                }

                if ((stats.qp >= stats.qp_slider.maxValue) & _alreadyplayed == false)
                {
                    CultureEndingScreen.SetActive(true);
                    ost.SetActive(false);
                    oneShotPlaySound.PlaySound(CultureEndingSound);
                    _alreadyplayed = true;
                }

                if ((stats.hp >= stats.hp_slider.maxValue) & _alreadyplayed == false)
                {
                    MoneyEndingScreen.SetActive(true);
                    ost.SetActive(false);
                    oneShotPlaySound.PlaySound(MoneyEndingSound);
                    _alreadyplayed = true;
                }
            }
        }
    }
}