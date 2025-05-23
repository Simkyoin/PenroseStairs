using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastScanner : MonoBehaviour
{
    public float range = 5f;
    public Camera playerCamera;
    public Text infoText;
    void Update()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, range))
        {
            infoText.text = hit.collider.name;
        }
        else
        {
            infoText.text = "";
        }
    }
}