﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagesController : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        { // Nous recuperons le tag de l'objet en colision

            col.gameObject.GetComponent<Inventory>().Life();
            audioSource.Play();
          
        }

    }
}
