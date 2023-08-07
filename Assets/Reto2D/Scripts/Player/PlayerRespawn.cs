using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    private string currentSceneName;

    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;

        if (PlayerPrefs.HasKey("CurrentScene"))
        {
            string savedSceneName = PlayerPrefs.GetString("CurrentScene");
            if (savedSceneName == currentSceneName)
            {
                if (PlayerPrefs.HasKey("checkPointPositionX") && PlayerPrefs.HasKey("checkPointPositionY"))
                {
                    float x = PlayerPrefs.GetFloat("checkPointPositionX");
                    float y = PlayerPrefs.GetFloat("checkPointPositionY");
                    transform.position = new Vector2(x, y);
                }
            }
        }
    }

    public void ReachedCheckedPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
        PlayerPrefs.SetString("CurrentScene", currentSceneName);
    }
}