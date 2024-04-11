using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Rigidbody2D rb;  //���������� ���������� ��� ����������� ����
    public Animator anim;  //���������� ���������� ��� ��������� � ������� �����
    public SpriteRenderer sr;  //���������� ���������� ��� ������� �����


    void Start()
    {
        //��������� �����������
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //����� ������� ��������, ��������, ������ � �������� �����
        walk();
        Flip();
        Jump();
        CheckingGround();

    }

    public Vector2 moveVector;  //���������� ������� ��������
    public float speed = 2f;  //���������� �������� 
    void walk()  //������� ��� �������� ����� ����� � ������
    {
        moveVector.x = Input.GetAxis("Horizontal");  //��������� ����� �� ������������
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));   //��������� �������� ��������
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);   //���������� ��������
    }

    void Flip()   //������� ��� �������� ����� � ����������� �� ����������� ��������
    {
        if (moveVector.x > 0)   //���� ����� �������� ������
        {
            sr.flipX = false;  //�� ������������ ������
        }
        else if (moveVector.x < 0)  //���� ����� �������� �����
        {
            sr.flipX=true;  //��������� ������
        }
    }

    public float jumpForce = 7f;  //���������� ���� ������
    private int jumpCount = 0;  //���������� �������� �������
    public int maxJumpValue = 2;  //���������� ����. ��������� �������
    void Jump()  //������� ��� ������ �����
    {
        //���� ����� �������� ������ � ����� �� ����� ��� ���������� ������� ������ ������������� ��������
        if (Input.GetKeyDown(KeyCode.Space) && (onGround || (++jumpCount < maxJumpValue))) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);  //���������� ���� ������ � ����������� ���� �����
        }

        if (onGround)   //���� ����� �� �����, �������� ���������� �������
        {
            jumpCount = 0;
        }
    }

    //���������� ���������� ��� �������� �����
    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;

    private void CheckingGround()  //������� ��� ��������, ��������� �� ����� �� �����
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);  //�������� ����������� � ������
        anim.SetBool("onGround", onGround);  //��������� ��������, ����� ����� �� �����
    }

    
}


