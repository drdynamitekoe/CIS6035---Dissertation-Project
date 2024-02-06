using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitcher : MonoBehaviour
{
    public GameObject camera1; //The first person camera
    public GameObject camera2; //The third person camera 
    public GameObject camera3; //The rear view camera
    public GameObject camera4; //The rear view camera
    public GameObject camera5; //The rear view camera
    public GameObject camera6; //The rear view camera

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) //If the button is pressed
        {
            camera1.SetActive(true); //The camera is changed to first person mode
            camera2.SetActive(false); //The third person camera is disabled
            camera3.SetActive(false); //The rear view camera is disabled
            camera4.SetActive(false); //The rear view camera is disabled
            camera5.SetActive(false); //The rear view camera is disabled
            camera6.SetActive(false); //The rear view camera is disabled
        }

        if (Input.GetKey(KeyCode.Alpha2)) //If the button is pressed
        {
            camera1.SetActive(false); //The camera is changed to first person mode
            camera2.SetActive(true); //The third person camera is disabled
            camera3.SetActive(false); //The rear view camera is disabled
            camera4.SetActive(false); //The rear view camera is disabled
            camera5.SetActive(false); //The rear view camera is disabled
            camera6.SetActive(false); //The rear view camera is disabled
        }

        if (Input.GetKey(KeyCode.Alpha3)) //If the button is pressed
        {
            camera1.SetActive(false); //The camera is changed to first person mode
            camera2.SetActive(false); //The third person camera is disabled
            camera3.SetActive(true); //The rear view camera is disabled
            camera4.SetActive(false); //The rear view camera is disabled
            camera5.SetActive(false); //The rear view camera is disabled
            camera6.SetActive(false); //The rear view camera is disabled
        }

        if (Input.GetKey(KeyCode.Alpha4)) //If the button is pressed
        {
            camera1.SetActive(false); //The camera is changed to first person mode
            camera2.SetActive(false); //The third person camera is disabled
            camera3.SetActive(false); //The rear view camera is disabled
            camera4.SetActive(true); //The rear view camera is disabled
            camera5.SetActive(false); //The rear view camera is disabled
            camera6.SetActive(false); //The rear view camera is disabled
        }

        if (Input.GetKey(KeyCode.Alpha5)) //If the button is pressed
        {
            camera1.SetActive(false); //The camera is changed to first person mode
            camera2.SetActive(false); //The third person camera is disabled
            camera3.SetActive(false); //The rear view camera is disabled
            camera4.SetActive(false); //The rear view camera is disabled
            camera5.SetActive(true); //The rear view camera is disabled
            camera6.SetActive(false); //The rear view camera is disabled
        }

        if (Input.GetKey(KeyCode.Alpha6)) //If the button is pressed
        {
            camera1.SetActive(false); //The camera is changed to first person mode
            camera2.SetActive(false); //The third person camera is disabled
            camera3.SetActive(false); //The rear view camera is disabled
            camera4.SetActive(false); //The rear view camera is disabled
            camera5.SetActive(false); //The rear view camera is disabled
            camera6.SetActive(true); //The rear view camera is disabled
        }


    }
}
