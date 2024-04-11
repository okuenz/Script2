using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isCharacterOnPlatform = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  //��������� ����������
        rb.gravityScale = 0; //���������� ���������� ��������� ��� ������
        rb.bodyType = RigidbodyType2D.Static; //��� ���� Static ��� ���������� ����������� �����������
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  //���� ������ ������ ����� ��� "Player"
        {
            isCharacterOnPlatform = true;  //�� �������� �� ���������
            rb.gravityScale = 1; //��������� ���������� ��������� ��� �������� � ����������
            rb.bodyType = RigidbodyType2D.Dynamic; //��� ���� Dynamic ��� ��������� ����������� �����������
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  //���� ������ ������ ����� ��� "Player"
        {
            isCharacterOnPlatform = false;
            rb.gravityScale = 0; //���������� ���������� ��������� ��� ������ �������� � ����������
            rb.bodyType = RigidbodyType2D.Static; //��� ���� Static ��� ���������� ����������� �����������
        }
    }
}

