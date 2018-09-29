using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : FauxGravityBody
{
    
    public float shrinkSpeed = 0.05f;
    public GameObject[] planets;
    bool isVanishing = false;
    public GameObject pickupEffect;
    private GameObject effect;

  
    void Update()
    {
        

        if (isVanishing)
            return;

        transform.localScale *= 1f - shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x <= .5f)
        {
            isVanishing = true;
            GetComponent<Animator>().SetTrigger("Vanish");
            Destroy(gameObject, .3f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        planets = GameObject.FindGameObjectsWithTag("Planet");

        if (other.CompareTag("Player"))
        {
            foreach (GameObject planet in planets)
            {
                planet.GetComponent<Planet>().growing = true;
               
            }
            pickedUp();
        }
    }

    void pickedUp()
    {
        effect = Instantiate(pickupEffect, transform.position, transform.rotation);

        Destroy(effect, 2);
        Destroy(gameObject);
    }
}
