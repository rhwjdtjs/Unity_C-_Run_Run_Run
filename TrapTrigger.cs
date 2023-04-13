using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrapTrigger : MonoBehaviour
{
    
    private void Awake()
    {
    }
    private void Start()
    {
   
    }
    private void OnTriggerEnter2D(Collider2D collision) //함정에 닿으면
    {
        //플레이어 파괴 및 죽음 카운터 + 및 스테이지 재로드
        Destroy(collision.gameObject);
        GameManager.isPlayerDead = true;
        GameManager.DeadCount += 1;
        Debug.Log(GameManager.isPlayerDead);
        SceneManager.LoadScene("Stage1");
    }
}
