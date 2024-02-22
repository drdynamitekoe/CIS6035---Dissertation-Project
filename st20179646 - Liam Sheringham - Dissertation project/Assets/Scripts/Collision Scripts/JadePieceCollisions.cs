using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JadePieceCollisions : MonoBehaviour
{
    [SerializeField] int pointValue; //The point value for the resource
    public TMP_Text scoreText; //The score within the HUD
    private int theScore = 0; //The score at the start of the level
    private int totalScore; //The players total score

    private void OnTriggerEnter(Collider other) //A collision is detected
    {

        if (other.gameObject.CompareTag("JadePiece"))
        {
            Destroy(gameObject); //The resource itself is destroyed
            totalScore += pointValue; //The total score is equated
            scoreText.text = totalScore.ToString(); //The score is converted in a way that it can be displayed in the HUD

        }
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
