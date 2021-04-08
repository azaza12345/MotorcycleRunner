using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    private float speed;
    private void Start()
    {
        speed = transform.parent.GetComponent<HousesSpawner>().speed;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    
    
}
