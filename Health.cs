using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Health : MonoBehaviour
{
    public int health;  //���������� ����������
    public int maxHealth;  //���������� ����������
    public Transform spawnPoint; //���������� ����������

    public void TakeHit(int damage)  //������� �� ��������� �����
    {
        health -= damage;  //���������� �������� ��������

        if (health <= 0)  //��������, ���� ������� �������� ������ ��� ����� ����
        {
            Respawn(); //����� ������
        }
    }

    void Respawn()  //�����, ������� ���������� ��������� �� �������������� �����
    { 
        transform.position = spawnPoint.position;  //��������� �������
        health = maxHealth;  //��������� �������� �������� �� ������������
    }
    public void SetHealth(int bonusHealth)  //������� ��� ���������� ��������
    {
        health += bonusHealth;  //����������� ������� ��������

        if (health > maxHealth)  //��������, ���� ������� �������� ������ �������������
        {
            health = maxHealth;  //������������� ������� �������� ������ �������������
        }
    }
}
