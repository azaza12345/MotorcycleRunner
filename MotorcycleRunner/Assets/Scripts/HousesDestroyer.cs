using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousesDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<House>())
            Destroy(other.gameObject);
    }
}
