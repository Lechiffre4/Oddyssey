using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject player;
    public GameObject portail;
    public GameObject lever;
    public GameObject portalsound;

    //sprite portail
    public Sprite portailOn;
    public Sprite portailOff;

    //sprite levier
    public Sprite LeverOn;
    public Sprite LeverOff;



    

    public void Start()
    {
        portail.gameObject.GetComponent<SpriteRenderer>().sprite = portailOff;


        portail.gameObject.GetComponent<Collider2D>().enabled = false;
        portalsound.gameObject.GetComponent<AudioSource>().enabled = false;

        lever.gameObject.GetComponent<SpriteRenderer>().sprite = LeverOff;
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            portail.gameObject.GetComponent<SpriteRenderer>().sprite = portailOn;


            portail.gameObject.GetComponent<Collider2D>().enabled = true;
            portalsound.gameObject.GetComponent<AudioSource>().enabled = true;


            lever.gameObject.GetComponent<SpriteRenderer>().sprite = LeverOn;

        }
    }
}
