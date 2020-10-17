using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();

    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0, 0);
    }
    private void _CheckBounds()
    { 
    if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }
    if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
