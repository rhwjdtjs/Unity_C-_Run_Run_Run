using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Maptrans : MonoBehaviour
{
    public string transfermapname;
    private Player theplayer;
    // Start is called before the first frame update
    void Start()
    {
        theplayer = FindObjectOfType<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            theplayer.currentMapName = transfermapname;
            SceneManager.LoadScene(transfermapname);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
