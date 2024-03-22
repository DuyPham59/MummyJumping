using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(Gametag.Player.ToString()))
        {
            Destroy(collision.gameObject);
            if (GameManager.Ins)
            {
                GameManager.Ins.state = GameState.Gameover;
            }
            if(GUIManager.Ins || GUIManager.Ins.gameOverDialog)
            {
                GUIManager.Ins.gameOverDialog.Show(true);
            }

            if(AudioController.Ins)
            {
                AudioController.Ins.PlaySound(AudioController.Ins.gotCollectable);
            }
            Debug.Log("gameover");
        }
        if(collision.CompareTag(Gametag.Platform.ToString()))
        {
            Destroy(collision.gameObject);
        }
    }
}
