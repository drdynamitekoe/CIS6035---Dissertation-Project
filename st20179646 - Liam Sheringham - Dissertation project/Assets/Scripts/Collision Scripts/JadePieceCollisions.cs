using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JadePieceCollisions : MonoBehaviour
{
    [SerializeField] int pointValue; //The point value for the resource
    public TMP_Text scoreText; //The score within the HUD
    public TMP_Text lifeText; //The score within the HUD
    private int theScore = 0; //The score at the start of the level
    private int totalScore; //The players total score
    private int lifeCount = 3;
    [SerializeField] private float turnSpeed = 30f;

    void Update()
    {
        transform.Rotate(Time.deltaTime * turnSpeed * Vector3.left);
    }

    void OnTriggerEnter(Collider collision) //A collision is detected
    {
        GameObject otherObject = collision.gameObject;
        scoreTracker myTracker = otherObject.GetComponent<scoreTracker>(); //The score tracker is located 

        if (myTracker != null)
        {
            Destroy(gameObject); //The resource itself is destroyed
            totalScore += pointValue; //The total score is equated
            scoreText.text = totalScore.ToString(); //The score is converted in a way that it can be displayed in the HUD

            if(totalScore >= 100)
            {
                lifeCount +=1;
            }
        }
    }

}