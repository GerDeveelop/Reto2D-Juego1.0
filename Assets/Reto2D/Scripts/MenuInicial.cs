using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // funcion cambio de escena

    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // funcion salir de escena

    public void Quit()
    {
        Debug.Log("salir...");
        Application.Quit();    
    }
}
