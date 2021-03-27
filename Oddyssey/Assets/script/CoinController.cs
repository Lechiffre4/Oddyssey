using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //public GameObject reward;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        { // Nous recuperons le tag de l'objet en colision

            col.gameObject.GetComponent<Inventory>().Coin();
            //Instantiate(reward, transform.position, Quaternion.identity);
            Destroy(gameObject.transform.root.gameObject); //detruit la hierarchie complete de l'objet rubis
        }

    }
}
