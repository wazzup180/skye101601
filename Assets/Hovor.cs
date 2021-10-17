using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hovor : MonoBehaviour

{
    // Start is called before the first frame update
    private void OnMouseDown()       //·Æ¹««ö¤U
    {
        Destroy(this.gameObject);
        Debug.Log("01");
    }

    private void OnMouseEnter()       //·Æ¹«²¾¤Jª«Åé
    {
        this.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        Debug.Log("02");
    }

    private void OnMouseOver()     //·Æ¹«Äa°±®É¨C´V©I¥s
    {
        this.transform.Rotate(new Vector3(10, 10, 10) * Time.deltaTime);
    }

    private void OnMouseExit()         //·Æ¹«²¾¥X
    {
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}