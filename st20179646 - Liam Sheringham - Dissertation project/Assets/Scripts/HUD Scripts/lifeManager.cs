using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour
{

    public GameObject lifeText;
    public int lifeCount;

    void OnTriggerEnter(Collider other)

    {
        lifeCount += 1;
        lifeText.GetComponent<Text>().text = lifeCount.ToString();
        Destroy(gameObject);
    }
}
