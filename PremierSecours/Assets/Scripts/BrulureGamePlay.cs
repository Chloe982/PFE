using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrulureGamePlay : MonoBehaviour
{
    public GameObject animVerte;
    public GameObject animRouge;
    public GameObject victime;
    public GameObject choix1;
    public GameObject message1;
    public GameObject choix2;
    public GameObject message2;
    public GameObject choix3;
    public GameObject choix4;
    public GameObject fin;
    public AudioSource buzzSound;
    public AudioSource checkSound;

    // Start is called before the first frame update
    void Start()
    {
        message1.gameObject.SetActive(false);
        message2.gameObject.SetActive(false);
        fin.gameObject.SetActive(false);
        choix2.gameObject.SetActive(false);
        choix3.gameObject.SetActive(false);
        choix4.gameObject.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    //CHOIX 1

    public void Retirer()
    {
        Vector3 position = new Vector3(-6f, 0.2f, 1.5f);
        // Vector3 position = choix1.transform.position;
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "retirer";
        StartCoroutine(Wait(flag));
        
    }

    public void PasToucher()
    {
        Vector3 position = new Vector3(-3f, 1.7f, -0.7f);
        AnimRouge(position);
       //explication
    }

    public void Dechirer()
    {
        Vector3 position = new Vector3(-7.6f, 1.8f, 0.6f);
        AnimRouge(position);
        //explication 
    }

    //CHOIX2 

    public void Temperature()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "temperature";
        StartCoroutine(Wait(flag));

    }

    public void Froide()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimRouge(position);
        //explication 
    }

    public void Glace()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimRouge(position);
        //explication 
    }

    //CHOIX 3

    public void Allonger()
    {
        Vector3 position = new Vector3(-4.2f, 0.7f, 1.5f);
        AnimVerte(position);
        
        string flag = "allonger";
        StartCoroutine(Wait(flag));

    }

    public void Bandage()
    {
        Vector3 position = new Vector3(-6.8f, 0.67f, -0.28f);
        AnimRouge(position);
        //explication 
    }

    public void Pommade()
    {
        Vector3 position = new Vector3(-5.0f, 1.46f, -1.9f);
        AnimRouge(position);
        //explication 
    }

    //CHOIX 4

    public void Appel()
    {
        Vector3 position = new Vector3(-5.22f, 1.25f, -1.15f);
        AnimVerte(position);

        string flag = "fin";
        StartCoroutine(Wait(flag));

    }

    public void BoireEau()
    {
        Vector3 position = new Vector3(-7.6f, 1.8f, 0.6f);
        AnimRouge(position);
        //explication 
    }

    public void Attendre()
    {
        Vector3 position = new Vector3(-4.2f, 0.7f, 1.5f);
        AnimRouge(position);
        //explication 
    }

    //ANIMATIONS

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

    //WAIT

    IEnumerator Wait(string flag)
    {
        
        yield return new WaitForSeconds(3);
        
        DiscardObjects(flag);
        
    }

    //CHANGEMENT DE CHOIX

    public void DiscardObjects(string flag)
    {
        if(flag == "retirer")
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
        else if (flag == "temperature")
        {
            choix2.gameObject.SetActive(false);
            message2.gameObject.SetActive(true);

            string msg = "message2";
            StartCoroutine(Wait(msg));
        }
        else if (flag == "message2")
        {
            message2.gameObject.SetActive(false);
            choix3.gameObject.SetActive(true);
        }
        else if (flag == "allonger")
        {
            choix3.gameObject.SetActive(false);
            victime.gameObject.SetActive(false);
            choix4.gameObject.SetActive(true);
        }
        else if (flag == "fin")
        {
            choix4.gameObject.SetActive(false);
            fin.gameObject.SetActive(true);
            
        }
    }

}
