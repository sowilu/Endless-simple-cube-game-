using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject dartPref;
    public float offset = 0;
    public float repeatTime = 1;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), offset, repeatTime);
    }

    void Spawn()
    {
        Instantiate(dartPref, transform.position, dartPref.transform.rotation);
    }
   
}
