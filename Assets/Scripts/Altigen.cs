using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class Altigen : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(Dondur());
    }

     IEnumerator Dondur()
  {
    Vector2 MousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,0));

    if (Input.GetMouseButtonDown(0) && MousePos.x > 0)
    {
        transform.Rotate(0,0,-30);
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(0,0,-30);
    }
    if (Input.GetMouseButtonDown(0) && MousePos.x < 0)
    {
        transform.Rotate(0,0,30);
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(0,0,30);
    }
  }

}
