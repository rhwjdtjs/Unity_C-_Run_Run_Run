using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text TimerText;
    [SerializeField]
    private Text ShowHelp;
    [SerializeField]
    private Text deadCount;
    [SerializeField]
    private Player theplayer;
    private float oneseconds = 6f;
    private float deadseconds = 2f;
    public bool isPause = true;
    [SerializeField]
    private Animator anim;
    private void Start()
    {
    }
    private void Update()
    {
        if (!GameManager.isPlayerDead)
            TimerFun();
        else
            DeadTimer();
        
    }
  private void TimerFun()
    { 
        oneseconds -= Time.deltaTime; //�ð��� ������ ���� ����
        TimerText.text = ((int)oneseconds % 60).ToString(); //�ؽ�Ʈ�� �ð� ���
        if (oneseconds <= 0) //�ð��� 0�� ���ϰ� ��ٸ�
        {
            theplayer.isRun = true; //�÷��̾ �޸��� ���� 
            anim.SetBool("isrun", theplayer.isRun);
            isPause = false;
            deadCount.gameObject.SetActive(false); //ui ��Ȱ��ȭ
            TimerText.gameObject.SetActive(false);
            ShowHelp.gameObject.SetActive(false);
        }
    }
    private void DeadTimer() //�׾��ٰ� ��Ȱ���� ��� 6�ʿ��� 2�ʷ� ī��Ʈ ����
    {
        deadseconds -= Time.deltaTime;
        deadCount.gameObject.SetActive(true);
        deadCount.text = "Number of Failed: : " + GameManager.DeadCount;
        TimerText.text = ((int)deadseconds % 60).ToString();
        if (deadseconds <= 0)
        {
            theplayer.isRun = true;
            anim.SetBool("isrun", theplayer.isRun);
            isPause = false;
            deadCount.gameObject.SetActive(false);
            TimerText.gameObject.SetActive(false);
            ShowHelp.gameObject.SetActive(false);
        }
    }

}
