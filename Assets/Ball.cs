using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private int time = 3;

    private bool canRetry = false;

    void Uptade()
    {
        if (canRetry)
        {
            BallLauncher.canLaunch = true;
            DragGameObject.canMove = true;
            canRetry = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject, time);
        canRetry = true;
    }
}
