using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lifeManager : MonoBehaviour
{

    public TMP_Text lifeText;
    public int lifeCount;

    void OnTriggerEnter(Collider collision) //A collision is detected
    {
        GameObject otherObject = collision.gameObject;
        lifeTracker myTracker = otherObject.GetComponent<lifeTracker>(); //The life tracker is located 

        if (myTracker != null)
        {
            Destroy(gameObject); 
            lifeCount = lifeCount + 1;
            lifeText.text = lifeCount.ToString(); //The additional life is converted in a way that it can be displayed in the HUD
        }
    }
}
