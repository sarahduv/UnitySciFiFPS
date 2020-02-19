using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private AudioClip _coinPickUp;

    private void Start()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Player player = other.GetComponent<Player>();
            if(player != null)
            {
                player.hasCoin = true;
                UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

                if(uiManager != null)
                {
                    uiManager.CollectedCoin();
                }

                // we have to use playClipAtPoint because we are destroying the object
                AudioSource.PlayClipAtPoint(_coinPickUp, Camera.main.transform.position, 1f);
                Destroy(this.gameObject);
            }
        }
    }
}
