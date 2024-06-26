using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;   //���������� ��������� ����������
    public Health playerHealth;  //���������� ��������� ���������� playerHealth

    private void Start()
    {
        SetMaxHealth(playerHealth.maxHealth);  //������������� ������������ �������� �������� ��� ������ ����
    }

    private void Update()
    {
        SetHealth(playerHealth.health);  //��������� ����������� �������� �� ������ �����
    }

    public void SetMaxHealth(int health)  //����� ��� ��������� ������������� �������� ��������
    {
        slider.maxValue = health;   //������������� ������������ �������� ��������
        slider.value = health;  //������������� ������� �������� ��������
    }

    public void SetHealth(int health)  //����� ��� ��������� �������� �������� ��������
    {
        slider.value = health;  //������������� ������� �������� ��������
    }

}
