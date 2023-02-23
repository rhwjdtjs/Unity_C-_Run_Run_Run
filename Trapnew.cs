using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapnew : MonoBehaviour
{
    private void Start()
    { 

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.Find("Trap").gameObject.SetActive(true);
    }
}
