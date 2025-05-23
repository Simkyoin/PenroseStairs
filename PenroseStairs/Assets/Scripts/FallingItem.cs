using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItem : MonoBehaviour
{
    public ItemData itemData;
    public float fallSpeed = 5f;
    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<ItemUse>()?.ActivateItem(itemData);
            Destroy(gameObject);
        }
    }
}
