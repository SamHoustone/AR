using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class shootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject Smoke;

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.CompareTag("ballon"))
            {
                Destroy(hit.transform.gameObject);
                Instantiate(Smoke, hit.point,Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
