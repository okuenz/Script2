using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;   //объявление публичной переменной
    public Health playerHealth;  //объявление публичной переменной playerHealth

    private void Start()
    {
        SetMaxHealth(playerHealth.maxHealth);  //устанавливает максимальное значение здоровья при старте игры
    }

    private void Update()
    {
        SetHealth(playerHealth.health);  //обновляет отображение здоровья на каждом кадре
    }

    public void SetMaxHealth(int health)  //метод для установки максимального значения здоровья
    {
        slider.maxValue = health;   //устанавливает максимальное значение здоровья
        slider.value = health;  //устанавливает текущее значение здоровья
    }

    public void SetHealth(int health)  //метод для установки текущего значения здоровья
    {
        slider.value = health;  //устанавливает текущее значение здоровья
    }

}
