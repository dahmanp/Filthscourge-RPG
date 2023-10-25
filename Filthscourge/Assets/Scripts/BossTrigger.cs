using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class BossTrigger : MonoBehaviourPun
{
    public GameObject boss;
    public GameObject toDisappear;
    public GameObject bossIntro;
    public AudioSource bossMusic;
    public AudioSource normalMusic;
    public GameObject noKeys;

    [PunRPC]
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if ((other.gameObject.GetComponent<PlayerController>().keys) >= 1)
            {
                toDisappear.SetActive(false);
                boss.SetActive(true);
                bossMusic.Play();
                normalMusic.Stop();
                bossIntro.SetActive(true);
                Invoke("setScreen", 3.0f);
                transform.position = new Vector3(0, 120, 0);
            } else
            {
                noKeys.SetActive(true);
                Invoke("setBadScreen", 3.0f);
            }
        }
    }

    void setScreen()
    {
        bossIntro.SetActive(false);
    }

    void setBadScreen()
    {
        noKeys.SetActive(false);
    }
}
