using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    public AudioSource Collected;
    private int cherries = 0;

 
    [SerializeField] private TextMeshProUGUI CherriesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Collected.Play();
            Destroy(collision.gameObject);
            cherries++;
            CherriesText.text = "CHERRIES: " + cherries;
        }
    }
}
