using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Health : MonoBehaviour
{
    public int health;  //объявление переменной
    public int maxHealth;  //объявление переменной
    public Transform spawnPoint; //объявление переменной

    public void TakeHit(int damage)  //функция дл получения урона
    {
        health -= damage;  //уменьшение текущего здоровья

        if (health <= 0)  //проверка, если текущее здоровье меньше или равно нулю
        {
            Respawn(); //вызов метода
        }
    }

    void Respawn()  //метод, который возвращает персонажа на первоначальную точку
    { 
        transform.position = spawnPoint.position;  //изменение позации
        health = maxHealth;  //изменение значения здоровья на максимальное
    }
    public void SetHealth(int bonusHealth)  //функция для добавления здоровья
    {
        health += bonusHealth;  //увеличиваем текущее здоровье

        if (health > maxHealth)  //проверка, если текущее здоровье больше максимального
        {
            health = maxHealth;  //устанавливаем текущее здоровье равным максимальному
        }
    }
}
