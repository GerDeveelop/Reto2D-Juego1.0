using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectApples : MonoBehaviour
{
    public AudioSource Collected;
    private int apples = 0;

 
    [SerializeField] private TextMeshProUGUI ApplesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apples"))
        {
            Collected.Play();
            Destroy(collision.gameObject);
            apples++;
            ApplesText.text = "Apples: " + apples;
        }
    }
}
