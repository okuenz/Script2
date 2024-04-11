using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPatrol : MonoBehaviour
{
    public float speed;  //���������� ���������� ��������
    public float distance;  //���������� ���������� ����������

    private bool movingRight = true;  //���������� ���������� ���� ������, ������� ���������� �������� �� ������ ������

    public Transform groundDetention;  //���������� ��� ����������� �����



    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);  //����������� ������� ������ � ������������ ���������

        //�������� ���� ���� �� ������� groundDetention �� ������������ ���������� � ���������� ���������� � ���������� groundInfo
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetention.position, Vector2.down, distance);

        if (groundInfo.collider == false) //��������, ���� �� ��������� ��� �������� groundDetention
        {
            if (movingRight == true)  //���� ������ �������� ������
            {
                transform.eulerAngles = new Vector3(0, 180, 0);  //���������� ������ �����
                movingRight = false;  //� ���������� movingRight � false
            }
            else  //���� ������ �������� �����
            {
                transform.eulerAngles = new Vector3(0, 0, 0);  //���������� ������ ������
                movingRight = true;  //� ���������� movingRight � true
            }
        }
    }
}
