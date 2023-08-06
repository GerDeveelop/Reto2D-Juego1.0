using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject[] Heart;
    private int life;

    private float checkPointPositionX, checkpointpositionY;

    public Animator animator;

    void Start()
    {
        life = Heart.Length;

        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    public void Checklife()
    {
        if (life < 1) 
        {
            Destroy(Heart[0].gameObject);
            animator.Play("Trap");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        else if (life > 2)
        {
            Destroy(Heart[1].gameObject);
            animator.Play("Trap");
        }
        else if(life < 3)
        {
            Destroy(Heart[2].gameObject);
            animator.Play("Trap");
        }
    }
    
    public void ReachedCheckPoint(float x, float y)

    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);

        PlayerPrefs.SetFloat("checkPointPositionY",y);
    }

    public void PlayerDamaged()
    {
        life--;
        Checklife();
    }

}