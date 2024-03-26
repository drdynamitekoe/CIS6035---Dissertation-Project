using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeTracker : MonoBehaviour
{
    [SerializeField] private int life = 3; 

    public int getLife()
    {
        return life; //the players number of lives
    }

    // Update is called once per frame
    public void setLife(int newLifeValue)
    {
        life = newLifeValue; 
    }

    public void incrementLife(int lifeToAdd)
    {
        life += lifeToAdd; //The number of lives is updated 
    }
}
