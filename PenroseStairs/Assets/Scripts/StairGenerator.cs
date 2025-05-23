using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairGenerator : MonoBehaviour
{
    public GameObject stepPrefab;
    public Transform parent;
    public LoopPlatformManager loopManager;

    void Start()
    {
        Vector3[] stepPositions = new Vector3[]
        {
        new Vector3( 0,  0.0f,  0),
        new Vector3( 4,  1.0f,  0),
        new Vector3( 8,  2.0f,  0),
        new Vector3( 8,  3.0f,  6),
        new Vector3( 8,  4.0f, 12),
        new Vector3( 4,  5.0f, 12),
        new Vector3( 0,  6.0f, 12),
        new Vector3(-4,  7.0f, 12),
        new Vector3(-4,  8.0f,  6),
        new Vector3(-4,  9.0f,  0),
        new Vector3( 0, 10.0f,  0),
        new Vector3( 0, 11.0f,  0) // Step12 = Step0 위치, 높이만 다름
        };

        Quaternion[] rotations = new Quaternion[]
        {
        Quaternion.Euler(0,   0, 0),
        Quaternion.Euler(0,   0, 0),
        Quaternion.Euler(0,   0, 0),
        Quaternion.Euler(0,  90, 0),
        Quaternion.Euler(0,  90, 0),
        Quaternion.Euler(0, 180, 0),
        Quaternion.Euler(0, 180, 0),
        Quaternion.Euler(0, 270, 0),
        Quaternion.Euler(0, 270, 0),
        Quaternion.Euler(0, 270, 0),
        Quaternion.Euler(0,   0, 0),
        Quaternion.Euler(0,   0, 0)
        };

        Transform[] stepTransforms = new Transform[stepPositions.Length];

        for (int i = 0; i < stepPositions.Length; i++)
        {
            GameObject step = Instantiate(stepPrefab, stepPositions[i], rotations[i]);
            step.name = "Platform_Step_" + (i + 1);
            if (parent != null) step.transform.parent = parent;
            stepTransforms[i] = step.transform;
        }

        if (loopManager != null)
            loopManager.platformSteps = stepTransforms;
    }
}