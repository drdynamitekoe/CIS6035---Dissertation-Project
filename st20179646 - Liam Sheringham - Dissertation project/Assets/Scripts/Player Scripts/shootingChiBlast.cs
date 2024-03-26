using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingChiBlast : MonoBehaviour
{
    public GameObject chiSpawn; public Transform spawnPoint; public GameObject chiBlast; //The bog standand chi blast
    public GameObject fireSpawn; public Transform spawnPoint2; public GameObject fireBlast; //The fire chi blast 
    public GameObject iceSpawn; public Transform spawnPoint3; public GameObject iceBlast; //The ice chi blast 
    public GameObject windSpawn; public Transform spawnPoint4; public GameObject windBlast; //The wind chi blast 
    public GameObject earthSpawn; public Transform spawnPoint5; public GameObject earthBlast; //The earth chi blast
    public GameObject lightningSpawn; public Transform spawnPoint6; public GameObject lightningBlast; //The lightning chi blast 

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
            ShootChi(); ShootFire(); ShootIce();
            ShootWind(); ShootEarth(); ShootLightning();
        }

    }

            void OnTriggerEnter(Collider other) //A collision is detected 
            {

                if (other.gameObject.CompareTag("Fire"))
                {
                    Destroy(other.gameObject);
                    chiBlast.SetActive(false); 
                    fireBlast.SetActive(true); 
                    iceBlast.SetActive(false); 
                    windBlast.SetActive(false); 
                    earthBlast.SetActive(false); 
                    lightningBlast.SetActive(false); 
                    StartCoroutine(Chi());
                }

                if (other.gameObject.CompareTag("Ice"))
                {
                    Destroy(other.gameObject);
                    chiBlast.SetActive(false);
                    fireBlast.SetActive(false); 
                    iceBlast.SetActive(true); 
                    windBlast.SetActive(false); 
                    earthBlast.SetActive(false); 
                    lightningBlast.SetActive(false); 
                    StartCoroutine(Chi());
                }

                if (other.gameObject.CompareTag("Wind"))
                {
                    Destroy(other.gameObject);
                    chiBlast.SetActive(false); 
                    fireBlast.SetActive(false); 
                    iceBlast.SetActive(false); 
                    windBlast.SetActive(true); 
                    earthBlast.SetActive(false); 
                    lightningBlast.SetActive(false); 
                    StartCoroutine(Chi());
                }

                if (other.gameObject.CompareTag("Earth"))
                {
                    Destroy(other.gameObject);
                    chiBlast.SetActive(false); 
                    fireBlast.SetActive(false);
                    iceBlast.SetActive(false); 
                    windBlast.SetActive(false); 
                    earthBlast.SetActive(true); 
                    lightningBlast.SetActive(false); 
                    StartCoroutine(Chi());
                }

                if (other.gameObject.CompareTag("Lightning"))
                {
                    Destroy(other.gameObject);
                    chiBlast.SetActive(false); 
                    fireBlast.SetActive(false);
                    iceBlast.SetActive(false);
                    windBlast.SetActive(false); 
                    earthBlast.SetActive(false);
                    lightningBlast.SetActive(true); 
                    StartCoroutine(Chi());
                }
            }

    public void ShootChi() //The function for the standard chi blast
    {

        GameObject cb = Instantiate(chiBlast, spawnPoint.position, chiBlast.transform.rotation); //The projectile prefab is instantiated at the spawnpoint
        Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
        transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
        rig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);
    }


public void ShootFire() //The function for the standard chi blast
{

    GameObject cb = Instantiate(fireBlast, spawnPoint2.position, fireBlast.transform.rotation); //The projectile prefab is instantiated at the spawnpoint
    Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
    transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
    rig.AddForce(spawnPoint2.forward * speed, ForceMode.Impulse);
}

public void ShootIce() //The function for the standard chi blast
{

    GameObject cb = Instantiate(iceBlast, spawnPoint3.position, iceBlast.transform.rotation); //The projectile prefab is instantiated at the spawnpoint
    Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
    transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
    rig.AddForce(spawnPoint3.forward * speed, ForceMode.Impulse);
}


public void ShootWind() //The function for the standard chi blast
{

    GameObject cb = Instantiate(windBlast, spawnPoint4.position, windBlast.transform.rotation); //The projectile prefab is instantiated at the spawnpoint
    Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
    transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
    rig.AddForce(spawnPoint4.forward * speed, ForceMode.Impulse);
}

public void ShootEarth() //The function for the standard chi blast
{

    GameObject cb = Instantiate(earthBlast, spawnPoint5.position, earthBlast.transform.rotation); //The projectile prefab is instantiated at the spawnpoint
    Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
    transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
    rig.AddForce(spawnPoint5.forward * speed, ForceMode.Impulse);
}


public void ShootLightning() //The function for the standard chi blast
{

    GameObject cb = Instantiate(lightningBlast, spawnPoint6.position, lightningBlast.transform.rotation); //The projectile prefab is instantiated at the spawnpoint
    Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
    transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
    rig.AddForce(spawnPoint6.forward * speed, ForceMode.Impulse);
}




IEnumerator Chi()
    {
        yield return new WaitForSeconds(20);
        chiBlast.SetActive(true); 
        fireBlast.SetActive(false); 
        iceBlast.SetActive(false); 
        windBlast.SetActive(false); 
        earthBlast.SetActive(false); 
        lightningBlast.SetActive(false); 
    }

}
       