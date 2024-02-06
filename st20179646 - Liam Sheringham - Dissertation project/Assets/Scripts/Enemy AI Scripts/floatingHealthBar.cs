using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floatingHealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthBar(float currentEnemyHealth, float maxEnemyHealth)
    {
        slider.value = currentEnemyHealth / maxEnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
