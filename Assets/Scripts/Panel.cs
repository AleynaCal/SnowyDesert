using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    public GameObject Oyunbitiş;
    public bool OyunBitti = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OyunBitti)
        {
            Oyunbitiş.SetActive(true);
        }
    }

    public void quit()
    {
        Application.Quit();
    }
    public void anamenü()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void yenidenbaşla()
    {

        SceneManager.LoadScene("SampleScene");
    }
}
