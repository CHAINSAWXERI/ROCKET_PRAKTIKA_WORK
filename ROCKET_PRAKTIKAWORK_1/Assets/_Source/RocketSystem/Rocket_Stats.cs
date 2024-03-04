using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class Rocket_Stats : MonoBehaviour
{
    [SerializeField] public int MaxValueSlider;
    [SerializeField] public int dp; //Level of development  of the population.   Уровень развития населения.
    [SerializeField] public int cp; //level of creativity of the population.     Уровень творчества населения.
    [SerializeField] public int qp; //Level of quality of the population.        Уровень качества населения.
    [SerializeField] public int hp; //Level of happiness of the population.      Уровень счастья населения.
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
