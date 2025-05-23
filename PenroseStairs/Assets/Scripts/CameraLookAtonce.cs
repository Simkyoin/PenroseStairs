using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtOnce : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0  , 14, -18);

    void Start()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target);
        }
    }
}