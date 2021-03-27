using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    public float climbspeed = 12;
    



  
    void OnTriggerStay2D ( Collider2D other)
    {



        if ((other.tag == "Player") && (Input.GetKey(KeyCode.UpArrow)))
        {
            
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbspeed);
            other.GetComponent<Animator>().SetBool("isClimbing", true);

        }
        else if ((other.tag == "Player") && (Input.GetKey(KeyCode.DownArrow)))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -climbspeed);
            other.GetComponent<Animator>().SetBool("isClimbing", true);
        }

        else
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0.01f);
            other.GetComponent<Animator>().SetBool("isClimbing", true);
        }
   
    }
    

    void OnTriggerExit2D(Collider2D other)
    {
        other.GetComponent<Animator>().SetBool("isClimbing", false);
    }
}

