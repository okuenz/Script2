using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody2D rb; //���������� ��������� ���������� rb

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  //��������� ���������
    }

    //����� OnTriggerEnter2D ����������, ����� ������ ������ � ��������� 2D ������ � ������� ����� �������
    private void OnTriggerEnter2D(Collider2D other)  
    {
        if (other.CompareTag("Player")) //���� ��� ������� ������� "Player"
        {
            rb.isKinematic = false;  //isKinematic � false, ��� ������ ������ ���������
            Destroy(gameObject, 2f); //����������� ����� �������� ������� ����� 2 �������
        }
    }

}

