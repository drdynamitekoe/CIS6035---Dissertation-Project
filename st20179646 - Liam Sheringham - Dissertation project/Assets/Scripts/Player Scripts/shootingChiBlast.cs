using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingChiBlast : MonoBehaviour
{
    public Transform spawnPoint; //The spawn point for the first projectile
    public GameObject chi; //The bog standand chi blast 
    public float speed = 300; //The speed of the projectile


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootChi(); //the function for the right button is pressed
        }
    }

    private void ShootChi() //The function for the standard chi blast
    {
          GameObject cb = Instantiate(chi, spawnPoint.position, chi.transform.rotation); //The projectile prefab is instantiated at the second spawnpoint
         Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
        transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
        rig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);
    }
}
       