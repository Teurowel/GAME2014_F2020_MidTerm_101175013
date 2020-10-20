//Source file name : BackgroundController.cs
//Student name : Doosung Jang
//Student ID : 101175013
//Date last modified : October, 20. 2020
//Program description : This class will control background movement
//Revision history : October, 20. 2020 : Added horizontalSpeed, horizontalBoundary varibales
//                                       Changed _Move, _Reset, _CheckBounds to adapt horizontal movement


//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
