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
    private void OnTriggerEnter2D(Collider2D collision) //������ ������
    {
        //�÷��̾� �ı� �� ���� ī���� + �� �������� ��ε�
        Destroy(collision.gameObject);
        GameManager.isPlayerDead = true;
        GameManager.DeadCount += 1;
        Debug.Log(GameManager.isPlayerDead);
        SceneManager.LoadScene("Stage1");
    }
}
