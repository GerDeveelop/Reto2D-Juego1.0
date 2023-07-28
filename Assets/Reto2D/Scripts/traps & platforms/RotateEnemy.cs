using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{

    public SpriteRenderer EnemyLR;



    private void Start()
    {

        EnemyLR = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("reverseL"))
        {
            EnemyLR.flipX = true;
        }

        else if (collision.gameObject.CompareTag("reverseR"))
        {
            EnemyLR.flipX = false;
        }
    }



}
