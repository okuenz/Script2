using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody2D rb; //объявление приватной переменной rb

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  //получение компонент
    }

    //метод OnTriggerEnter2D вызывается, когда другой объект с триггером 2D входит в триггер этого объекта
    private void OnTriggerEnter2D(Collider2D other)  
    {
        if (other.CompareTag("Player")) //если тег другого объекта "Player"
        {
            rb.isKinematic = false;  //isKinematic в false, что делает объект подвижным
            Destroy(gameObject, 2f); //уничтожение этого игрового объекта через 2 секунды
        }
    }

}

