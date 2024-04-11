using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform Hero;  //приватная переменная для хранения позации героя

    private void Start()
    {
        Hero = GameObject.FindGameObjectWithTag("Player").transform;  //нахождение объекта с тегом "Player"
    }

    private void Update()
    {
        Vector3 temp = transform.position;  //текущая позиция камеры
        temp.x = Hero.position.x;  //создание координаыт x, которая равна позиции героя, равной его x координате
        temp.y = Hero.position.y;  //создание координаты y, которая равна позиции героя, равной его y координате

        transform.position = temp;  //присвоение камере этой позиции
    }

}
