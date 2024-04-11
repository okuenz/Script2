using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{
    public int collisionHeal = 1; //объявление переменной, которая хранит указанное количество здоровья 
    public string collisionTag;  //объявление переменной, которая хранит тег объекта

    private void OnCollisionEnter2D(Collision2D collision) //Функция, вызываемая при столкновении объектов
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();  //Получение компонента Health объекта
            health.SetHealth(collisionHeal); //Установка нового значения здоровья объекта
            Destroy(gameObject);  //Уничтожение объекта
        }
    }
}
