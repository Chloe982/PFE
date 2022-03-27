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
    public GameObject choix3;
    public GameObject message3;
    public GameObject choix4;
    public GameObject message4;
    public GameObject fin;
    public GameObject defibrillateur;

    public AudioSource buzzSound;
    public AudioSource checkSound;


    // Start is called before the first frame update
    void Start()
    {
        message1.gameObject.SetActive(false);
        message2.gameObject.SetActive(false);
        message3.gameObject.SetActive(false);
        message4.gameObject.SetActive(false);
        fin.gameObject.SetActive(false);
        choix2.gameObject.SetActive(false);
        choix3.gameObject.SetActive(false);
        choix4.gameObject.SetActive(false);
        defibrillateur.gameObject.SetActive(false);
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

    //CHOIX 3

    public void Pose1()
    {
        Vector3 position = new Vector3(-0.486f, 0.369f, 6.714f);
        AnimRouge(position);        
    }

    public void Pose2()
    {
        Vector3 position = new Vector3(1.231f, 0.369f, 4.165f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "pose2";
        StartCoroutine(Wait(flag));
        
    }

    public void Pose3()
    {
        Vector3 position = new Vector3(-2.288f, 0.369f, 3.637f);
        AnimRouge(position);        
    }

    //CHOIX 4


    public void ReprendreMassage()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimVerte(position);
        //desactiver les 3 canvas et activer le suivant
        string flag = "ReprendreMassage";
        StartCoroutine(Wait(flag));
        
    }
    
    public void Enlever()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimRouge(position);        
    }

    public void AttendreSecours()
    {
        Vector3 position = new Vector3(0.755f, 0.734f, 6.151f);
        AnimRouge(position);        
    }

    //Animation des réponses
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


    //Temps de pause
    IEnumerator Wait(string flag)
    {
        
        yield return new WaitForSeconds(3);
        
        DiscardObjects(flag);
        
    }

    IEnumerator WaitMessage(string flag)
    {
        
        yield return new WaitForSeconds(10);
        
        DiscardObjects(flag);
        
    }

    public void DiscardObjects(string flag)
    {
        if(flag == "pouls")
        {
            
            choix1.gameObject.SetActive(false);
            message1.gameObject.SetActive(true);

            string msg = "message1";
            StartCoroutine(WaitMessage(msg));
        }
        else if (flag == "message1")
        {
            message1.gameObject.SetActive(false);
            choix2.gameObject.SetActive(true);
        }
        else if(flag == "massage")
        {
            
            choix2.gameObject.SetActive(false);
            message2.gameObject.SetActive(true);

            string msg = "message2";
            StartCoroutine(WaitMessage(msg));
        }
        else if (flag == "message2")
        {
            message2.gameObject.SetActive(false);
            defibrillateur.gameObject.SetActive(true);
            choix3.gameObject.SetActive(true);
        }
        else if (flag == "pose2")
        {
            choix3.gameObject.SetActive(false);
            message3.gameObject.SetActive(true);
            
            string msg = "message3";
            StartCoroutine(WaitMessage(msg));
        }
        else if (flag == "message3")
        {
            choix4.gameObject.SetActive(true);
            message3.gameObject.SetActive(false);
        }
        else if (flag == "ReprendreMassage")
        {
            choix4.gameObject.SetActive(false);
            message4.gameObject.SetActive(true);

            string msg = "fin";
            StartCoroutine(WaitMessage(msg));
        }
        else if(flag == "fin")
        {
            fin.gameObject.SetActive(true);
            message4.gameObject.SetActive(false);
            victime.gameObject.SetActive(false);
            defibrillateur.gameObject.SetActive(false);
        }
        
    }    

}
