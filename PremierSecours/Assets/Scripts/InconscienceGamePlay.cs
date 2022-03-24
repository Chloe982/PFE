using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InconscienceGamePlay : MonoBehaviour
{
    public GameObject animVerte;
    public GameObject animRouge;


    // Start is called before the first frame update
    void Start()
    {
        GameObject respire = GameObject.Find("CanvaRespire");
        respire.gameObject.SetActive(false);
        GameObject massage = GameObject.Find("CanvaMassage");
        massage.gameObject.SetActive(false);
        GameObject bouche = GameObject.Find("CanvaBouche");
        bouche.gameObject.SetActive(false);
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
        //string flag = "reaction";
        //StartCoroutine(Wait(flag));
        //Wait();

    }

    public void Massage()
    {
        Vector3 position = new Vector3(-7.6f, 1.8f, 0.6f);
        AnimRouge(position);
        //explication 
    }

    public void Bouche()
    {
        Vector3 position = new Vector3(-7.6f, 1.8f, 0.6f);
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
        Debug.Log("AVANT");
        yield return new WaitForSeconds(3);
        Debug.Log("APRES");
        DiscardObjects(flag);
        
    }

    public void DiscardObjects(string flag)
    {
        if(flag == "reaction")
        {
            GameObject partir = GameObject.Find("CanvaPartir");
            partir.gameObject.SetActive(false);
            GameObject reaction = GameObject.Find("CanvaReaction");
            reaction.gameObject.SetActive(false);
            GameObject jeterEau = GameObject.Find("CanvaJeterEau");
            jeterEau.gameObject.SetActive(false);

            /*
            GameObject respire = GameObject.Find("CanvaRespire");
            respire.gameObject.SetActive(true);
            GameObject massage = GameObject.Find("CanvaMassage");
            massage.gameObject.SetActive(true);
            GameObject bouche = GameObject.Find("CanvaBouche");
            bouche.gameObject.SetActive(true);
            */
        }
    }

}
