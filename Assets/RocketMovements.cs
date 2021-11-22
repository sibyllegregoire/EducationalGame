using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovements : MonoBehaviour
{
    public float increment = 20;
    public float decrement = 20;
    public Vector2 targetPos;
    float speed = 50;

    public float limitup = 8.6f;
    public float limitdown = -8.7f;

    public void Awake()
    {
        //targetPos = new Vector2(x: -11, y: 0);
        targetPos = transform.position;
    }

    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    public void moveUp()
    {
        //transform.position = new Vector3(x: 104, y: 256, z: 0);
        //if (transform.position.y >= limitup)
        //{
        //    targetPos = new Vector2(x: transform.position.x, y: 8.6f);
        //}
        //else
        //{
            targetPos = new Vector2(x: 104, y: 256);
        //}
    }

    public void moveDown()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y - decrement, z: 0);
        if (transform.position.y <= limitdown)
        {
            targetPos = new Vector2(x: transform.position.x, y: -8.7f);
        }
        else
        {
            targetPos = new Vector2(x: transform.position.x, y: transform.position.y - decrement);
        }
    }
}