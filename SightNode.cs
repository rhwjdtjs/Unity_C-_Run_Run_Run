using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightNode : MonoBehaviour
{
    private Rigidbody2D therigid;
    // Start is called before the first frame update
    void Start()
    {
        therigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.SetActive(false);
    }
}
