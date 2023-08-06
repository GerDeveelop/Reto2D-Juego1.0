using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{


    private float checkPointPositionX, checkpointpositionY;


    void Start()
    {
      

        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

      
    public void ReachedCheckPoint(float x, float y)

    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);

        PlayerPrefs.SetFloat("checkPointPositionY",y);
    }

}