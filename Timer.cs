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
        oneseconds -= Time.deltaTime; //시간을 프레임 마다 감소
        TimerText.text = ((int)oneseconds % 60).ToString(); //텍스트에 시간 기록
        if (oneseconds <= 0) //시간이 0초 이하가 됬다면
        {
            theplayer.isRun = true; //플레이어가 달리기 시작 
            anim.SetBool("isrun", theplayer.isRun);
            isPause = false;
            deadCount.gameObject.SetActive(false); //ui 비활성화
            TimerText.gameObject.SetActive(false);
            ShowHelp.gameObject.SetActive(false);
        }
    }
    private void DeadTimer() //죽었다가 부활했을 경우 6초에서 2초로 카운트 감소
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
