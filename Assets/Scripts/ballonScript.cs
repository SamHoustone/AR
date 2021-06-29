using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballonScript : MonoBehaviour
{
    public float speed;
   // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Destroy(gameObject, 20);
    }
}
