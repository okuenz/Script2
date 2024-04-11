using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Rigidbody2D rb;  //объ€вление переменной дл€ физического тела
    public Animator anim;  //объ€вление переменной дл€ аниматора и спрайта геро€
    public SpriteRenderer sr;  //объ€вление переменной дл€ спрайта геро€


    void Start()
    {
        //получение компонентов
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //вызов функций движени€, поворота, прыжка и проверки земли
        walk();
        Flip();
        Jump();
        CheckingGround();

    }

    public Vector2 moveVector;  //объ€вление вектора движени€
    public float speed = 2f;  //объ€вление скорости 
    void walk()  //функци€ дл€ движени€ геро€ влево и вправо
    {
        moveVector.x = Input.GetAxis("Horizontal");  //получение ввода от пользовател€
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));   //установка анимации движени€
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);   //применение скорости
    }

    void Flip()   //функци€ дл€ поворота геро€ в зависимости от направлени€ движени€
    {
        if (moveVector.x > 0)   //если герой движетс€ вправо
        {
            sr.flipX = false;  //не поворачивать спрайт
        }
        else if (moveVector.x < 0)  //если герой движетс€ влево
        {
            sr.flipX=true;  //повернуть спрайт
        }
    }

    public float jumpForce = 7f;  //объ€вление силы прыжка
    private int jumpCount = 0;  //объ€вление счетчика прыжков
    public int maxJumpValue = 2;  //объ€вление макс. колиества прыжков
    void Jump()  //функци€ дл€ прыжка геро€
    {
        //если игрок нажимает пробел и герой на земле или количество прыжков меньше максимального значени€
        if (Input.GetKeyDown(KeyCode.Space) && (onGround || (++jumpCount < maxJumpValue))) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);  //применение силы прыжка к физическому телу геро€
        }

        if (onGround)   //если герой на земле, сбросить количество прыжков
        {
            jumpCount = 0;
        }
    }

    //объ€вление переменных дл€ проверки земли
    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;

    private void CheckingGround()  //функци€ дл€ проверки, находитс€ ли герой на земле
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);  //проверка пересечени€ с землей
        anim.SetBool("onGround", onGround);  //установка анимации, когда герой на земле
    }

    
}


