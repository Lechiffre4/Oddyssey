using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingspike : MonoBehaviour
{
    public float Destroy_Delay = 1.2f;
    public GameObject player;
    //public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroy_Timer(Destroy_Delay));
        
    }

    public void Destroyer()
    {

        Destroy(gameObject);

    }

    public IEnumerator Destroy_Timer(float Delay)
    {
        yield return new WaitForSeconds(Delay);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //le TP et le son ne veulent pas s'activer
            //player.gameObject.GetComponent<Transform>().transform.position = new Vector4(115.9081f, -27.5f, 0f);
            //audioSource.gameObject.GetComponent<AudioSource>().Play();
            Destroyer();
        }
    }
}
