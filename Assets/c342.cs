using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c342 : MonoBehaviour
{
    public Light myLight;
    public Light T;

    private void OnMouseDown()
    {
        Debug.Log("«ö¤U«ö¶s");
    }

    private void OnMouseUp()
    {
        Application.OpenURL("https://www.cg.com.tw/UnityCSharp/Content/Mouse.php");
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("space"))
        { myLight.enabled = true; }
        else
        {
            myLight.enabled = false;
        }
    }
}