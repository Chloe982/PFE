using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InconscienceGamePlay : MonoBehaviour
{
    public GameObject animVerte;
    public GameObject animRouge;
    public GameObject victime;
    public GameObject choix1;
    public GameObject choix2;
    public GameObject choix3;
    public GameObject choix4;

    // Start is called before the first frame update
    void Start()
    {
        choix2.gameObject.SetActive(false);
        choix3.gameObject.SetActive(false);
        choix4.gameObject.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    //CHOIX 1

    public void Reaction()
    {
        Vector3 position = new Vector3(-6f, 0.2f, 1.5f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "reaction";
        StartCoroutine(Wait(flag));
        
    }

    public void Partir()
    {
        Vector3 position = new Vector3(-3f, 1.7f, -0.7f);
        AnimRouge(position);
       //explication
    }

    public void JeterEau()
    {
        Vector3 position = new Vector3(-7.6f, 1.8f, 0.6f);
        AnimRouge(position);
        //explication 
    }

    //CHOIX2 

    public void Respire()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "respire";
        StartCoroutine(Wait(flag));

    }

    public void Massage()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimRouge(position);
        //explication 
    }

    public void Bouche()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimRouge(position);
        //explication 
    }

    //CHOIX 3

    public void Pls()
    {
        Vector3 position = new Vector3(-4.2f, 0.7f, 1.5f);
        AnimVerte(position);
        
        string flag = "pls";
        StartCoroutine(Wait(flag));

    }

    public void Pos1()
    {
        Vector3 position = new Vector3(-6.8f, 0.67f, -0.28f);
        AnimRouge(position);
        //explication 
    }

    public void Pos2()
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

        //string flag = "pls";
        //StartCoroutine(Wait(flag));

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
        Destroy(feuVert, 3);

    }

    public void AnimRouge(Vector3 position)
    {
        GameObject feuRouge = Instantiate(animRouge, position, Quaternion.identity) as GameObject;
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
        if(flag == "reaction")
        {
            
            choix1.gameObject.SetActive(false);
            choix2.gameObject.SetActive(true);
            
        }
        else if (flag == "respire")
        {
            choix2.gameObject.SetActive(false);
            choix3.gameObject.SetActive(true);
        }
        else if (flag == "pls")
        {
            choix3.gameObject.SetActive(false);
            victime.gameObject.SetActive(false);
            choix4.gameObject.SetActive(true);
        }
    }

}
