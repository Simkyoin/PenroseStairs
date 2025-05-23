using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPlatformManager : MonoBehaviour
{
    public Transform[] platformSteps;
    public Transform loopResetPoint;
    public float loopHeight = 12.0f;
    public Transform player;

    void Update()
    {
        if (player.position.y > loopHeight)
        {
            Vector3 offset = new Vector3(0, loopHeight, 0);
            player.position -= offset;
            foreach (Transform step in platformSteps)
                step.position -= offset;
        }
    }
}