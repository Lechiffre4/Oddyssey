using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int nbCoin = 0;
    public Text coinText;
    public int nbLife = 3;
    public Slider slider;
    // Start is called before the first frame update

    void Update()
    {
        coinText.text = nbCoin.ToString();
        slider.value = nbLife;
    }


    public void Coin()
    {
        ++nbCoin;
    }

    public void Life()
    {
        --nbLife;
        if (nbLife == 0)
        {
            Debug.Log("T'es mort!");
            SceneManager.LoadScene("Mort");
        }
    }

    public int Getlife()
    {
        return nbLife;
    }

    public int GetCoin()
    {
        return nbCoin;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = 3;
        slider.value = 3;
    }
}
