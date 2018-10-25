using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyByBoundary : MonoBehaviour {

   public void OnTriggerExit( Collider collision)
    {
        Destroy(collision.gameObject); 
    }
}
