//Source file name : EnemyController.cs
//Student name : Doosung Jang
//Student ID : 101175013
//Date last modified : October, 20. 2020
//Program description : This class will control enemy
//Revision history : October, 20. 2020 : Added verticalSpeed, verticalBoundary
//                                       Changed _Move, _CheckBounds to adapt vertical movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
