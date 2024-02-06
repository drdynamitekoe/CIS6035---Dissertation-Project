using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earthquake : MonoBehaviour
{
    public float timeBetweenQuakes = 30; //The time between each individual earthquake
    public float timeForQuakes = 15; //The time that the earthquakes are active for
    public GameObject palace; //The boss level pagoda
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
            StartCoroutine(EarthquakeEffect());
        }
        if (timeForQuakes <= 0)
        {
            StartCoroutine(Stable());
        }

    }

    IEnumerator EarthquakeEffect()
    {
        timeForQuakes -= Time.deltaTime;
        palace.GetComponent<Animator>().Play("Earthquake");
        palace.GetComponent<Animator>().Play("Slow Meteors");
        yield return new WaitForSeconds(15);
        timeBetweenQuakes = 30;
    }


    IEnumerator Stable()
    {
        timeBetweenQuakes -= Time.deltaTime;
        palace.GetComponent<Animator>().Play("Stable");
        yield return new WaitForSeconds(1);
        timeForQuakes = 15;
    }

}
