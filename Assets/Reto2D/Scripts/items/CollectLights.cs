using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectLights : MonoBehaviour
{
    public AudioSource Collected;
    private int Lights = 0;

 
    [SerializeField] private TextMeshProUGUI LightsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lights"))
        {
            Collected.Play();
            Destroy(collision.gameObject);
            Lights++;
            LightsText.text = "LIGHTS: " + Lights;
        }
    }
}
