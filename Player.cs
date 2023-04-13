using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool GameEnd = false;
    public bool isRun = false;
    public string currentMapName;
    private bool isJump = false;
    private bool isGround = false;
    [SerializeField]
    private float JumpForce;
    [SerializeField]
    public Animator anim;
    private Timer thetimer;
    private Rigidbody2D therigidbody;
    private BoxCollider2D theboxcollider;
    [SerializeField]
    public float Speed ;
    [SerializeField]
    private AudioSource therun;
    [SerializeField]
    private AudioSource thejump;
    private void Start()
    {
        thetimer = FindObjectOfType<Timer>();
        DontDestroyOnLoad(this.gameObject);
        therigidbody = GetComponent<Rigidbody2D>();
        theboxcollider = GetComponent<BoxCollider2D>();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround) //플레이어가 땅에 붙어있다면
            {
                if (!GameEnd) //게임이 끝나지 않았다면
                {
                    isJump = true; //점프를 true
                    Debug.Log("Jump");
                    therigidbody.velocity = Vector3.up * JumpForce; //위로 플레이어를 점프시킨다
                    anim.SetBool("IsJump", isJump); //점프 애니메이션 활성화
                }
            }
        }
    }
    public void Moving(float _Speed)
    {
        transform.Translate(_Speed * Time.deltaTime, 0, 0); //플레이어를 이동시킨다.
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") //땅에 닿았을경우
        {
            isGround = true; //isground true
            isJump = false; //점프 비활성화
            anim.SetBool("IsJump", isJump); //애니메이션 변경
        }
    }
    void Update()
    {
        if (!thetimer.isPause) //타이머가 끝났을 겨우
        {
            Jump();
            Moving(Speed);
        }
        sound();
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
    private void sound()
    {
        if (isGround)
            therun.Play();
        if (isJump)
            thejump.Play();
    }
    void FixedUpdate()
    {
        if (therigidbody.velocity.y < 0) //점프를 뛰었을경우
        {
            Debug.DrawRay(therigidbody.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(therigidbody.position, Vector3.down, 1, LayerMask.GetMask("Ground")); //플레이어 위치에서 아래로 빔을 쏨
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.5f) //아래와 거리가 0.5f 이하일 경우
                {
                    isGround = true; //땅 true
                }
                else
                    isGround = false; //그외에 땅이 아님.
            }
            else
                isGround = false;
        }
        else if (therigidbody.velocity.y > 3)
            isGround = false;
    }
}
