using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public Slider slider; //The health bar
    public Gradient gradient; //Health bar gradient
    public Image fill; //The amount of healh within th bar

    public void SetMaxEnemyHealth(int enemyHealth) //The starting helath value (100%)
    {
        slider.maxValue = enemyHealth; //The max health is set
        slider.value = enemyHealth; //The health value within the slider
        fill.color = gradient.Evaluate(1f); //The gradient of the health bar
    }

    public void SetEnemyHealth(int enemyHealth)
    {
        slider.value = enemyHealth; //The health value within the slider
        fill.color = gradient.Evaluate(slider.normalizedValue); //The gradient of the health bar
    }
}
