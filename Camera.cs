using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform Hero;  //��������� ���������� ��� �������� ������� �����

    private void Start()
    {
        Hero = GameObject.FindGameObjectWithTag("Player").transform;  //���������� ������� � ����� "Player"
    }

    private void Update()
    {
        Vector3 temp = transform.position;  //������� ������� ������
        temp.x = Hero.position.x;  //�������� ���������� x, ������� ����� ������� �����, ������ ��� x ����������
        temp.y = Hero.position.y;  //�������� ���������� y, ������� ����� ������� �����, ������ ��� y ����������

        transform.position = temp;  //���������� ������ ���� �������
    }

}
