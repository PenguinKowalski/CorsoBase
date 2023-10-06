using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Porta : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Vector3 posizioneIniziple, rotazione;

    [SerializeField]
    float moltiplicatore = 1f;


    List<float> lista;
    Dictionary<float, float> dizionario= new Dictionary<float, float>();
    float[] array;

    [SerializeField]
    GameObject tmp;

    [SerializeField]
    Material matNuovo, matVecchio;
    MeshRenderer[] meshRenderer;
    private void Start()
    {
        tmp= Instantiate(prefab, posizioneIniziple,Quaternion.identity);
        // tmp= GameObject.Find("sedia");
        tmp.transform.parent = null;
        //tmp = GameObject.FindAnyObjectByType();

        for (int i=0; i< tmp.transform.childCount; i++)
        {
            if (tmp.transform.GetChild(i).name == "Cube")
            {
                tmp.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
      
        //GameObject.F

        Debug.Log("test");
        meshRenderer = tmp.GetComponentsInChildren<MeshRenderer>();
        if (meshRenderer.Length> 0)
        {
            matVecchio = meshRenderer[0].sharedMaterial;
        }


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //tmp.SetActive(!tmp.activeInHierarchy);

            // Destroy(tmp);

            //tmp.transform.position = tmp.transform.position + vettoreSpostamento;

            if (meshRenderer.Length > 0)
            {
                if (meshRenderer[0].sharedMaterial== matNuovo)
                {
                    foreach (MeshRenderer mr in meshRenderer)
                    {
                        mr.sharedMaterial = matVecchio;
                    }
                }
                else
                {
                    foreach (MeshRenderer mr in meshRenderer)
                    {
                        mr.sharedMaterial = matNuovo;
                    }
                }
            }

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //tmp.transform.position += Vector3.left * moltiplicatore;
            tmp.transform.Rotate(Vector3.left * moltiplicatore);
   
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //tmp.transform.position += Vector3.right * moltiplicatore;
            tmp.transform.Rotate(Vector3.right * moltiplicatore);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //tmp.transform.position += Vector3.back * moltiplicatore;
            tmp.transform.Rotate(Vector3.back * moltiplicatore);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // tmp.transform.position += Vector3.forward * moltiplicatore;
            tmp.transform.Rotate(Vector3.forward * moltiplicatore);
        }



    }


}
