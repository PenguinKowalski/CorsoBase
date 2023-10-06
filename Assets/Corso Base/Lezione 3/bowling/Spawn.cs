using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawns_birilli;
    public Transform spawn_palla;


    public GameObject prefab_birilli, prefab_palla;

    public List<GameObject> birilli;
    public Palla palla;

    bool endGame = false;

    public UIManager uiManager;

    public int totalScore = 0;

    private void Start()
    {
        Setup();
        uiManager.SetScore(0);
    }

    public bool IsBirilliFermi()
    {
        foreach (GameObject birillo in birilli)
        {
            if (!birillo.GetComponent<Rigidbody>().IsSleeping())
            {
                return false;
            }
        }
        return true;
    }

    void Setup()
    {
        endGame = false;
        if (palla != null)
        {
            Destroy(palla.gameObject);
        }
        foreach (GameObject birillo in birilli)
        {
            Destroy(birillo);
        }
        birilli = new List<GameObject>();
        for (int i=0; i< spawns_birilli.Length; i++)
        {
            birilli.Add(Instantiate(prefab_birilli, spawns_birilli[i].position, spawns_birilli[i].rotation));
        }
        palla = Instantiate(prefab_palla, spawn_palla.position, spawn_palla.rotation).GetComponent<Palla>();
    }


    private void Update()
    {
        if (palla.stato == StatoTiro.Tiro && palla.pallaRb.IsSleeping())
        {
            if (IsBirilliFermi() && !endGame)
            {
                endGame = true;
                StartCoroutine(FineTurno());
            }
        }
    }

    public void NewRound()
    {
        Setup();
    }
    IEnumerator FineTurno()
    {
        int score = ConteggioPunti();
        totalScore += score;
        Debug.Log("RISULTATO LANCIO=" + score);

        yield return new WaitForSeconds(1f);
        uiManager.EndGamePopup(score, totalScore);
        yield return null;
    }
    public void DestroyPalla()
    {
        Destroy(palla);
        palla = null;

    }
    public void DestroyBirillo(GameObject birillo)
    {
        if (birillo != null)
        {
            Destroy(birillo);

            if (birilli.Contains(birillo))
            {
                birilli.Remove(birillo);
            }           
        }      
    }

    public int ConteggioPunti()
    {
        int punti = 0;
        foreach (GameObject birillo in birilli)
        {
            Birillo birilloScript= birillo.GetComponent<Birillo>();
            if (birilloScript.Caduto)
            {
                punti++;
            }
        }
        return punti;
    }
   
}
