using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // left mouse button
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.point);
                Vector3 point = new Vector3(0, 0, hit.point.z);
                transform.LookAt(point);
            }
        }
    }
}
