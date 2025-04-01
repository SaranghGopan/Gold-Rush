using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    public int collectedCoins = 0;
    public TMP_Text coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collectedCoins = PlayerPrefs.GetInt("Coins");
        coinText.text = collectedCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Coin")
        {
            Debug.Log(collision.gameObject.tag);
            Destroy(collision.gameObject);
            collectedCoins++;
            PlayerPrefs.SetInt("Coins", collectedCoins);
            coinText.text = collectedCoins.ToString();
        }
    }
}
