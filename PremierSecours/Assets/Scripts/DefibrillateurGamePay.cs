using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefibrillateurGamePay : MonoBehaviour
{
    public GameObject animVerte;
    public GameObject animRouge;
    public GameObject victime;
    public GameObject choix1;
    public GameObject message1;
    public GameObject choix2;
    public GameObject message2;
    public AudioSource buzzSound;
    public AudioSource checkSound;

    // Start is called before the first frame update
    void Start()
    {
        message1.gameObject.SetActive(false);
        message2.gameObject.SetActive(false);
        choix2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // CHOIX 1
    public void Pouls()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "pouls";
        StartCoroutine(Wait(flag));
        
    }

    public void JeterEau()
    {
        Vector3 position = new Vector3(0.483f, 1.563f, 7.566f);
        AnimRouge(position);
        //explication 
    }

    public void Pls()
    {
        Vector3 position = new Vector3(1.16f, 0.933f, 3.999f);
        AnimRouge(position);
    }

    //CHOIX 2


    public void Massage()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "massage";
        StartCoroutine(Wait(flag));
        
    }
    
    public void Attendre()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimRouge(position);        
    }

    public void Deplacer()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimRouge(position);        
    }


    public void AnimVerte(Vector3 position)
    {
        GameObject feuVert = Instantiate(animVerte, position, Quaternion.identity) as GameObject;
        checkSound.Play();
        Destroy(feuVert, 3);

    }

    public void AnimRouge(Vector3 position)
    {
        GameObject feuRouge = Instantiate(animRouge, position, Quaternion.identity) as GameObject;
        buzzSound.Play();
        Destroy(feuRouge, 3);
    }



    IEnumerator Wait(string flag)
    {
        
        yield return new WaitForSeconds(3);
        
        DiscardObjects(flag);
        
    }

    public void DiscardObjects(string flag)
    {
        if(flag == "pouls")
        {
            
            choix1.gameObject.SetActive(false);
            message1.gameObject.SetActive(true);

            string msg = "message1";
            StartCoroutine(Wait(msg));
        }
        else if (flag == "message1")
        {
            message1.gameObject.SetActive(false);
            choix2.gameObject.SetActive(true);
        }
        if(flag == "massage")
        {
            
            choix2.gameObject.SetActive(false);
            message2.gameObject.SetActive(true);

            string msg = "message2";
            StartCoroutine(Wait(msg));
        }
        else if (flag == "message2")
        {
            message2.gameObject.SetActive(false);
            //choix3.gameObject.SetActive(true);
        }
    }    

}
