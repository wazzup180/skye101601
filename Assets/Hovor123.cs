using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hovor123 : MonoBehaviour
{
    public Renderer rend;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        rend.material.color = Color.blue;
    }

    private void OnMouseUp()
    {
        Application.OpenURL("https://www.cg.com.tw/UnityCSharp/Content/Mouse.php");
    }

    private void OnMouseDown()
    {
        Debug.Log("«ö¤U«ö¶s");
    }

    // Update is called once per frame
    private void Update()
    {
    }
}