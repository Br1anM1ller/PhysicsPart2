using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public void SetGravity()
    {
        Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y, -15f);
    }
}
