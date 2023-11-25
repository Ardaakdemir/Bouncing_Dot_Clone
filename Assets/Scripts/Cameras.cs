using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    private bool basla = false;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if(basla == false)
        {
        if(Input.GetMouseButton(0))
        {
            basla = true;
            GetComponent<AudioSource>().Play();
        }
        }
    }
}
