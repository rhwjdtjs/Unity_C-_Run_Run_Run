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
        if(collision.gameObject.tag=="Player") //함정에 플레이어가 닿았다면
        {
            theplayer.currentMapName = transfermapname;
            SceneManager.LoadScene(transfermapname); //다시 플레이어를 맵 처음으로 이동시킴
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
