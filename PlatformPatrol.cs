using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPatrol : MonoBehaviour
{
    public float speed;  //объ€вление переменной скорости
    public float distance;  //объ€вление переменной рассто€ни€

    private bool movingRight = true;  //объ€вление переменной типа булева, котора€ определ€ет движетс€ ли объект вправо

    public Transform groundDetention;  //переменна€ дл€ обнаружени€ земли



    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);  //перемещение объекта вправо с определенной скоростью

        //отправка луча вниз от позиции groundDetention на определенное рассто€ние и сохранение информации в переменной groundInfo
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetention.position, Vector2.down, distance);

        if (groundInfo.collider == false) //проверка, есть ли коллайдер под позицией groundDetention
        {
            if (movingRight == true)  //если объект движетс€ вправо
            {
                transform.eulerAngles = new Vector3(0, 180, 0);  //развернуть объект влево
                movingRight = false;  //и установить movingRight в false
            }
            else  //если объект движетс€ влево
            {
                transform.eulerAngles = new Vector3(0, 0, 0);  //развернуть объект вправо
                movingRight = true;  //и установить movingRight в true
            }
        }
    }
}
