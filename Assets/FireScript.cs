using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public Rigidbody cannonBall;
    public Transform origin;
    public float magnitude;
    public float mass;
    public float drag;

    // Update is called once per frame
    void Update()
    {
        cannonBall.mass = mass;
        cannonBall.drag = drag;
        if (Input.GetButtonDown("Fire1"))  // or Input.GetAxis("Fire1") !=0
        {
            Rigidbody newCannonBall = Instantiate(cannonBall, origin.position, origin.rotation);
            newCannonBall.AddForce(origin.up * magnitude, ForceMode.Impulse);
        }
    }
}