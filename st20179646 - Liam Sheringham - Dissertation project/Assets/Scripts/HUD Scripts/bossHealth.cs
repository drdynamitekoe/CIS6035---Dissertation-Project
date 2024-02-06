using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealth : MonoBehaviour
{
    public Slider slider; //The health bar
    public Gradient gradient; //Health bar gradient
    public Image fill; //The amount of healh within th bar

    public void SetMaxBossHealth(int bossHealth) //The starting helath value (100%)
    {
        slider.maxValue = bossHealth; //The max health is set
        slider.value = bossHealth; //The health value within the slider
        fill.color = gradient.Evaluate(1f); //The gradient of the health bar
    }

    public void SetBossHealth(int bossHealth)
    {
        slider.value = bossHealth; //The health value within the slider
        fill.color = gradient.Evaluate(slider.normalizedValue); //The gradient of the health bar
    }
}