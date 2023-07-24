using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private float CheckPointPositionX, CheckPointPositionY,

    Void Start ()
    {
        if (PlayerPrefs.GetFloat("CheckPositionX")!=0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("CheckPointPositionX"), PlayerPrefs.GetFloat("CheckPointPositionY")));
        }
    }

    Void ReachedChekPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("ChekPointPositionX",x);

        PlayerPrefs.SetFloat("ChekPointPositionY",y);
    }
}
