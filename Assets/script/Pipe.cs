using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] protected float Speed = 2.5f;

   
    // Update is called once per frame
    void Update()
    {
        this.PipeMove();
    }

    protected virtual void PipeMove()
    {
        this.transform.position += Vector3.left * this.Speed * Time.deltaTime;
    }    
}
