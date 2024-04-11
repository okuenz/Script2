using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 1;  //определение публичной переменной, которая хранит в себе значение наносимого урона
    public string collisionTag; 

    private void OnCollisionEnter2D(Collision2D collision)  //функция, вызываемая при столкновении объектов
    {
        if (collision.gameObject.tag == collisionTag)
        { 
            Health health = collision.gameObject.GetComponent<Health>();  //получение компонента Health у объекта столкновения
            health.TakeHit(collisionDamage); //вызов функции TakeHit
        }
    }
}
