using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MazeTrigger : MonoBehaviourPun
{
    public GameObject mazeIntro;
    public GameObject obstacle;
    public GameObject noCoins;

    [PunRPC]
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if ((other.gameObject.GetComponent<PlayerController>().gold) >= 100)
            {
                obstacle.SetActive(false);
                setMazeScreen();
                transform.position = new Vector3(0, 120, 0);
                mazeIntro.SetActive(true);
                Invoke("setMazeScreen", 3.0f);
            }
            else
            {
                noCoins.SetActive(true);
                Invoke("setBadScreen", 3.0f);
            }
        }
    }

    void setMazeScreen()
    {
        mazeIntro.SetActive(false);
    }

    void setBadScreen()
    {
        noCoins.SetActive(false);
    }
}
