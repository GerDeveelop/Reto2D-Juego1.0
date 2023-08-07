using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    private Vector2 initialPosition;
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

    public void RestartLevel(string nombre)
    {
        SceneManager.LoadScene(nombre);
        // También podemos borrar el checkpoint guardado para que el jugador empiece desde el inicio del nivel
        PlayerPrefs.DeleteKey("checkPointPositionX");
        PlayerPrefs.DeleteKey("checkPointPositionY");
    }
    // funcion salir de escena

    public void Quit()
    {
        Debug.Log("salir...");
        Application.Quit();    
    }
}
