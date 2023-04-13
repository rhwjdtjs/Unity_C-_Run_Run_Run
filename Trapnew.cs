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
        transform.Find("Trap").gameObject.SetActive(true); //일부 콜라이더와 닿았을 경우 일부 트랩 활성화
    }
}
