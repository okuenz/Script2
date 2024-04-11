using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bug : MonoBehaviour
{
    private float bugs = 0;  //переменная для подсчета жуков
    public TMP_Text bugsText;  //переменная для вывода текста
    private void OnTriggerEnter2D(Collider2D coll)  //функция, которая срабатывает при столкновении с другим объектом
    { 
        if (coll.gameObject.tag == "Bug")  
        {
            bugs++; //увеличиваем счетчик на 1
            bugsText.text = bugs.ToString();  //обновление текста
            Destroy(coll.gameObject);  //уничтожение объекта
        }
    }
}
