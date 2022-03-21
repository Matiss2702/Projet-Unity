using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistoletScript : MonoBehaviour
{
    public GameObject projectile;
    public Transform posTir;
    public float force;
    public int chargeur = 10;
    public AudioSource sfx;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && chargeur != 0)
        {
            sfx.Play();

            GameObject bullet = Instantiate(projectile, posTir.position, Quaternion.identity);

            bullet.GetComponent<Rigidbody>().AddForce(posTir.TransformDirection(Vector3.forward) * -force);

            Destroy(bullet, 5);

            chargeur--;
        }
        if (Input.GetKey("r"))
        {
            chargeur = 10;
        }
    }
}
