using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Transform parentPanel;
    [SerializeField]
    GameObject prefabPanel;

    PanelScore panel;

    [SerializeField]
    TextMeshProUGUI totalScoreText;



    [SerializeField]
    Spawn spawn;


    private void Start()
    {
        panel = Instantiate(prefabPanel, parentPanel).GetComponent<PanelScore>();
    }
    public void EndGamePopup(int punteggio, int totalscore)
    {
       
        panel.SetData(punteggio, spawn);

        SetScore(totalscore);
    }

    public void SetScore(int score)
    {
        totalScoreText.text = score + " Punti";

    }


}
