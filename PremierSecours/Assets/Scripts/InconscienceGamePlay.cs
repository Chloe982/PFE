using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InconscienceGamePlay : MonoBehaviour
{
    public GameObject animVerte;
    public GameObject animRouge;
    public GameObject choix1;
    public GameObject choix2;
    public GameObject choix3;


    // Start is called before the first frame update
    void Start()
    {
        choix2.gameObject.SetActive(false);
        choix3.gameObject.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reaction()
    {
        Vector3 position = new Vector3(-6f, 0.2f, 1.5f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "reaction";
        StartCoroutine(Wait(flag));
        //Wait();
        
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

    public void Respire()
    {
        Vector3 position = new Vector3(-5.7f, 0.7f, 1.5f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "respire";
        StartCoroutine(Wait(flag));
        //Wait();

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

    IEnumerator Wait(string flag)
    {
        
        yield return new WaitForSeconds(3);
        
        DiscardObjects(flag);
        
    }

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
    }

}
