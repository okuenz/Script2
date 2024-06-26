using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{
    public int collisionHeal = 1; //���������� ����������, ������� ������ ��������� ���������� �������� 
    public string collisionTag;  //���������� ����������, ������� ������ ��� �������

    private void OnCollisionEnter2D(Collision2D collision) //�������, ���������� ��� ������������ ��������
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();  //��������� ���������� Health �������
            health.SetHealth(collisionHeal); //��������� ������ �������� �������� �������
            Destroy(gameObject);  //����������� �������
        }
    }
}
