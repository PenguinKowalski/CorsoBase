using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class CuboMovimento : MonoBehaviour
{
    [SerializeField] Vector3 posStart, posEnd;
    [SerializeField] float speed=1;
    [SerializeField] int waitStart, waitEnd;

    public float t = 0;
    int segno = 1;

    public bool attendi = false;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        this.transform.position = Vector3.Lerp(posStart, posEnd, t);
        StartCoroutine(Movimento());
        /*
        LeanTween.move(this.gameObject, posEnd, speed).setDelay(waitStart).setLoopType(LeanTweenType.linear).setOnComplete(()=>
        {
            LeanTween.move(this.gameObject, posStart, speed).setDelay(waitEnd);
        });
        */
    }

#if UNITY_EDITOR
    public void Update()
    {
       // Debug.Log(this.transform.position);
    }
#endif

    IEnumerator Movimento()
    {
        while (true)
        {
            if (t < 0)
            {
                segno = 1;
                yield return new WaitForSeconds(waitStart);
            }
            if (t >= 1)
            {
                segno = -1;
                yield return new WaitForSeconds(waitEnd);
            }
            t += speed * Time.deltaTime * segno;
            this.transform.position = Vector3.Lerp(posStart, posEnd, t);
            yield return new WaitForEndOfFrame();
       }
    }
    
    /* Non riesco a fare il timer
     void Update()
     {
         if (t < 0)
         {
             segno = 1;
         }
         if (t >= 1)
         {        
             attendi = true;
         }

         if (!attendi)
         {
             t += speed * Time.deltaTime * segno;
             this.transform.position = Vector3.Lerp(posStart, posEnd, t);
         }  
         else
         {
             timer += Time.deltaTime;
             if (timer > waitEnd)
             {
                 attendi = false;
                 segno = -1;
                 timer = 0f;
             }
         }

     }
    */



}
