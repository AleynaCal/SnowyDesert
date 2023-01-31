using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puan : MonoBehaviour
{
    public int score = 0;
    public Text scoreyazısı;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Puan")
        {
            scoreyazısı.text = "Score = " + score++;
            Destroy(collision.gameObject);
        }
    }
}
