using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{
    private bool isUsingItem = false;
    private float originalSpeed;
    private PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        originalSpeed = playerMovement.moveSpeed;
    }
    public void ActivateItem(ItemData item)
    {
        if (!isUsingItem) StartCoroutine(UseItem(item));
    }
    System.Collections.IEnumerator UseItem(ItemData item)
    {
        isUsingItem = true;
        playerMovement.moveSpeed *= item.speedMultiplier;
        yield return new WaitForSeconds(item.effectDuration);
        playerMovement.moveSpeed = originalSpeed;
        isUsingItem = false;
    }
}