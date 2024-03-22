using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChecking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Gametag.Platform.ToString()))
        {
            var platformCol = collision.GetComponent<Platform>();

            if (!platformCol || !GameManager.Ins || !GameManager.Ins.LastPLatformSpawned) return;

            if(platformCol.ID == GameManager.Ins.LastPLatformSpawned.ID)
            {
                GameManager.Ins.SpawnPlatform();
            }
        }
    }
}
