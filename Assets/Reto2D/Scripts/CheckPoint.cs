using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.CompareTag("player"))
        {
            collision.GetComponent<PlayerRespawn>().ReachedCheckpoint(transform,position.x,transform.position.y);
        }
    }
}
