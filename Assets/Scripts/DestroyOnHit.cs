using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;
    public void OnTriggerEnter(Collider other)
    {   if (other.tag == "Boudary")
            return;
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
            
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
