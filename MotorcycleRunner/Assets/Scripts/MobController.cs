using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    private float speed;

    void Start()
    {
        speed = transform.parent.GetComponent<MobSpawner>().speed;
    }

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
