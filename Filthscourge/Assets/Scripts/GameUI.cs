using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;

    public TextMeshProUGUI keyText;

    public Image winBackground;

    public GameObject introScreen;

    // instance
    public static GameUI instance;
    void Awake()
    {
        instance = this;
        introScreen.SetActive(true);
        Invoke("setIntroScreen", 3.0f);
    }

    void setIntroScreen()
    {
        introScreen.SetActive(false);
    }

    public void UpdateGoldText(int gold)
    {
        goldText.text = "<b>Gold:</b> " + gold;
    }

    public void UpdateKeysText(int keys)
    {
        keyText.text = "<b>Keys:</b> " + keys;
    }

    public void SetWinText()
    {
        winBackground.gameObject.SetActive(true);
    }
}
