using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olme : MonoBehaviour
{   //Platform
    public Panel panel;
    void Start()
    {
       panel = GameObject.Find("Karakter").GetComponent<Panel>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Vucut")
        {
            panel.OyunBitti = true;
        }
    }
}
