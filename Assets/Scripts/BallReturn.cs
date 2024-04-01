using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    public Transform plunger;
    public GameObject ballPrefab;
    public float respawnDelay = 1f;

    private bool ballFell = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballFell = true;
            Destroy(other.gameObject);
            Invoke("RespawnBall", respawnDelay);
        }
    }

    void RespawnBall()
    {
        Instantiate(ballPrefab, plunger.position, Quaternion.identity);
        ballFell = false;
    }

    void Update()
    {
        if (ballFell)
        {
        }
    }
}
