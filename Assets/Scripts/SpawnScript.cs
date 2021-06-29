using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ballons;
    public Color[] Colors;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("Done");
            int Randomnum = Random.Range(0,3);
            GameObject go = Instantiate(ballons[i], spawnPoints[i].position, ballons[i].transform.rotation);
            go.GetComponent<Renderer>().material.color = Colors[Randomnum];
        }
        yield return new WaitForSeconds(4f);
        StartCoroutine(StartSpawning());
    }
}
