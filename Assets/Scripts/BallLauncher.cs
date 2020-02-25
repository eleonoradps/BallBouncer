using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject ballPrefab;

    float bulletForce = 10f;

    private bool canLaunch = true;

    //public AudioSource bulletSound;


    public void Shoot()
    {

        if (canLaunch)
        {
            GameObject bullet = Instantiate(ballPrefab, launchPoint.position, launchPoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(launchPoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
