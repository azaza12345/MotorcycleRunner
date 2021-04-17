using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<House>() || other.gameObject.GetComponent<MobController>())
            Destroy(other.gameObject);
    }
}
