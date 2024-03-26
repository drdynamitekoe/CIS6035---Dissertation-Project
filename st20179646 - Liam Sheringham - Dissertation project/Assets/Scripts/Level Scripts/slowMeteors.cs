using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slowMeteors : MonoBehaviour
{
    public float timeBetweenQuakes = 30; //The time between each individual earthquake
    public float timeForQuakes = 15; //The time that the earthquakes are active for
    public GameObject meteors; //The boss level pagoda
    Animator shake;
    Animator still;

    // Start is called before the first frame update
    public void Update()
    {

        if (timeBetweenQuakes > 0)
        {
            StartCoroutine(Stable());
        }
        if (timeBetweenQuakes <= 0)
        {
            StartCoroutine(SlowMeteors());
        }
        if (timeForQuakes <= 0)
        {
            StartCoroutine(Stable());
        }

    }

    IEnumerator SlowMeteors()
    {
        timeForQuakes -= Time.deltaTime;
        meteors.GetComponent<Animator>().Play("Slow Meteors");
        yield return new WaitForSeconds(15);
        timeBetweenQuakes = 30;
    }


    IEnumerator Stable()
    {
        timeBetweenQuakes -= Time.deltaTime;
        meteors.GetComponent<Animator>().Play("NoMeteors");
        yield return new WaitForSeconds(1);
        timeForQuakes = 15;
    }

}

