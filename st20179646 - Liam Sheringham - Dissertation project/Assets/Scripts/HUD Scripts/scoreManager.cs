using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{

    public GameObject jadePieceText;
    public int jadePieceCount;
    public GameObject livesText;
    public int livesCount;


    void OnTriggerEnter(Collider other)

    {
        jadePieceCount += 1;
        jadePieceText.GetComponent<Text>().text = jadePieceCount.ToString();
        Destroy(gameObject);

        if (jadePieceCount >= 100)
        {
            livesCount += 1;
        }
    }
}
