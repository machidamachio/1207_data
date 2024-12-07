using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coindestory : MonoBehaviour
{
    private int coinCount = 0;
    public TextMeshProUGUI coinText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCount += 1;

            coinText.text = "coin："+ coinCount.ToString("0");

            GameObject.Destroy(collision.gameObject);
        }



    }



}
