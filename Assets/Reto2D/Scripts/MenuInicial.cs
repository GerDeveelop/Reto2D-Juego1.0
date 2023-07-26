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
    //funcion seleccion de nivel
     public void Niveles(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    // funcion salir de escena

    public void Quit()
    {
        Debug.Log("salir...");
        Application.Quit();    
    }
}
