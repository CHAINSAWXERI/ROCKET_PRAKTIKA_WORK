using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class Rocket_Stats : MonoBehaviour
{
    [SerializeField] public int MaxValueSlider;
    [SerializeField] public int dp; //Уровень интелекта населения.
    [SerializeField] public int cp; //Уровень мощь населения.
    [SerializeField] public int qp; //Уровень культурность населения.
    [SerializeField] public int hp; //Уровень деньги населения.
    [SerializeField] public Slider dp_slider;
    [SerializeField] public Slider cp_slider;
    [SerializeField] public Slider qp_slider;
    [SerializeField] public Slider hp_slider;

    void Start()
    {
        dp_slider.maxValue = MaxValueSlider;
        cp_slider.maxValue = MaxValueSlider;
        qp_slider.maxValue = MaxValueSlider;
        hp_slider.maxValue = MaxValueSlider;
    }
    void Update()
    {
        dp_slider.value = dp;
        cp_slider.value = cp;
        qp_slider.value = qp;
        hp_slider.value = hp;
    }
}
