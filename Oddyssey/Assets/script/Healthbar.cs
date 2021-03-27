using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;
    




    // Start is called before the first frame update
    public void SetMaxHealth(int health)
    {
        slider.maxValue = 3;
        slider.value = 3;
    }


    public void SetHealth()
    {
        slider.value = GameObject.Find("astronut").GetComponent<Inventory>().Getlife();;
    }
}
