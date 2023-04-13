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
            if (isGround) //�÷��̾ ���� �پ��ִٸ�
            {
                if (!GameEnd) //������ ������ �ʾҴٸ�
                {
                    isJump = true; //������ true
                    Debug.Log("Jump");
                    therigidbody.velocity = Vector3.up * JumpForce; //���� �÷��̾ ������Ų��
                    anim.SetBool("IsJump", isJump); //���� �ִϸ��̼� Ȱ��ȭ
                }
            }
        }
    }
    public void Moving(float _Speed)
    {
        transform.Translate(_Speed * Time.deltaTime, 0, 0); //�÷��̾ �̵���Ų��.
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") //���� ��������
        {
            isGround = true; //isground true
            isJump = false; //���� ��Ȱ��ȭ
            anim.SetBool("IsJump", isJump); //�ִϸ��̼� ����
        }
    }
    void Update()
    {
        if (!thetimer.isPause) //Ÿ�̸Ӱ� ������ �ܿ�
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
        if (therigidbody.velocity.y < 0) //������ �پ������
        {
            Debug.DrawRay(therigidbody.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(therigidbody.position, Vector3.down, 1, LayerMask.GetMask("Ground")); //�÷��̾� ��ġ���� �Ʒ��� ���� ��
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.5f) //�Ʒ��� �Ÿ��� 0.5f ������ ���
                {
                    isGround = true; //�� true
                }
                else
                    isGround = false; //�׿ܿ� ���� �ƴ�.
            }
            else
                isGround = false;
        }
        else if (therigidbody.velocity.y > 3)
            isGround = false;
    }
}
