using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
   //player walks into collectable
   //add collectable to inventory
   //delete collectable

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player != null)
        {
            player.numBerries++;
            Destroy(this.gameObject);
        }
    }
}
