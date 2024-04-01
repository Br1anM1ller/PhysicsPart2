using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseAnchor : MonoBehaviour
{
    public void Release()
    {
        GameObject[] kinematicObjects = GameObject.FindGameObjectsWithTag("KinematicObject");

        foreach (GameObject obj in kinematicObjects)
        {
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
            }
        }
    }
}
