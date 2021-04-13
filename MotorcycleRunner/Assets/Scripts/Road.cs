using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private Vector2 startPosition;
    [SerializeField] private float repeatWidth;
    [SerializeField] private float speed;

    private void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    private void Update()
    {
        MoveLeft();
        RepeatRoad();
    }

    private void MoveLeft()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));
    }

    private void RepeatRoad()
    {
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
