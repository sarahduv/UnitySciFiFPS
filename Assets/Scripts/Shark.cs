using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Player player = other.GetComponent<Player>();

            if (player != null && player.hasCoin)
            {
                player.hasCoin = false;
                UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                if(uiManager != null)
                {
                    uiManager.RemoveCoin();
                }

                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                player.EnableWeapons();
            }
            else
            {
                Debug.Log("Get out of here.");
            }
        }
    }
}
