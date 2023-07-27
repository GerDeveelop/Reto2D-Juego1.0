using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject Enemy;

    private Animator animR;
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        if (target != null)
        {

            Vector3 followPosition = target.position + offset;

            transform.position = followPosition;
        }
    }
    void Start()
    {
        if (target != null)
        {
            offset = transform.position - target.position;
        }

        animR = Enemy.GetComponent<Animator>();
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(Enemy);
            Destroy(gameObject);

        }

    }
}

