using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isCharacterOnPlatform = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  //получение компонента
        rb.gravityScale = 0; //отключение гравитацию платформы при старте
        rb.bodyType = RigidbodyType2D.Static; //тип тела Static для отключения физического воздействия
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  //если другой объект имеет тег "Player"
        {
            isCharacterOnPlatform = true;  //то персонаж на платформе
            rb.gravityScale = 1; //включение гравитации платформы при контакте с персонажем
            rb.bodyType = RigidbodyType2D.Dynamic; //тип тела Dynamic для включения физического воздействия
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  //если другой объект имеет тег "Player"
        {
            isCharacterOnPlatform = false;
            rb.gravityScale = 0; //отключение гравитации платформы при потере контакта с персонажем
            rb.bodyType = RigidbodyType2D.Static; //тип тела Static для отключения физического воздействия
        }
    }
}

