using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public AudioSource checkPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            checkPoint.Play();
            collision.GetComponent<PlayerRespawn>().ReachedCheckedPoint(transform.position.x,transform.position.y);
            GetComponent<Animator>().enabled = true;
        }
    }
}
