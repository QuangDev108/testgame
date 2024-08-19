using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        this.Display();
    }

    // Update is called once per frame
    protected virtual void Display()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.SetActive(false);
        }    
    }    
}
