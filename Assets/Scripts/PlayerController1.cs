using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boudary {
    public float xMin, xMax, zMin, zMax;
}
public class PlayerController1 : MonoBehaviour {
    public float speed;
    public float tilt;
    public Boudary bd;
    public GameObject shot;
    public Transform shotSpawn;
    private float nextFire = 0.0f , fireRate = 0.25f ;
    
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }   
        }
    void FixedUpdate () {
        Rigidbody rb = GetComponent<Rigidbody>();
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector3(moveH, 0.0f, moveV) * speed  ;
        rb.position = new Vector3(Mathf.Clamp( rb.position.x, bd.xMin, bd.xMax), 0.0f, Mathf.Clamp(rb.position.z , bd.zMin, bd.zMax));
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
	}
}
