using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI actualScoreText;

    Spawn spawn;

    private void Start()
    {
        this.gameObject.SetActive(false);
    }
    public void EndGameOnClick()
    {
        spawn.NewRound();
        this.gameObject.SetActive(false);
    }

    public void SetData(int punteggio, Spawn _spawn)
    {
        this.gameObject.SetActive(true);
        actualScoreText.text = "Hai ottenuto " + punteggio + " punti";

        spawn = _spawn;
    }

}
