using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        Vector3 newPos = target.position;
        newPos.z = -10;
        transform.position = newPos;
    }
}
