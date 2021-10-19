using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        // find when cannon ball land on plane to determine shooting range
        Vector3 position = contact.point;

        // after ball land, log position
        // Cannon position is fixed at x value of 27.2
        Debug.Log("Shooting range");
        // take log position - cannon position
        Debug.Log(27.2 - position.x);
    }
}
