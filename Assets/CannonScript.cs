using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // w key to aim up
        if (Input.GetKeyDown("w"))
        {
            // change of y axis
            transform.Rotate(-Vector3.right, 5.0F); // projectile launch angle
            Debug.Log("Angle: ");
            Debug.Log(90 - transform.rotation.eulerAngles.x);
        }

        // s key to aim down
        if (Input.GetKeyDown("s"))
        {
            // change of y axis
            transform.Rotate(Vector3.right, 5.0F); // projectile launch angle
            Debug.Log("Angle: ");
            Debug.Log(90 - transform.rotation.eulerAngles.x);
        }

    }
}
