using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Yonetici : MonoBehaviour
{
    private bool basla = false;
    public GameObject tob,Alti,click;

    void Start()
    {
        Alti.GetComponent<Altigen>().enabled = false;
    }


    void Update()
    {
        if(basla == false)
        {
            if(Input.GetMouseButtonDown(0))
            {
            tob.transform.position = new Vector2(0,(float)0.79);
            basla = true;
            Alti.GetComponent<Altigen>().enabled = true;
            tob.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            click.SetActive(false);
            }
        }
    }
    public void Kapat()
    {
        Application.Quit();
    }
}
