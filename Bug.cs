using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bug : MonoBehaviour
{
    private float bugs = 0;  //���������� ��� �������� �����
    public TMP_Text bugsText;  //���������� ��� ������ ������
    private void OnTriggerEnter2D(Collider2D coll)  //�������, ������� ����������� ��� ������������ � ������ ��������
    { 
        if (coll.gameObject.tag == "Bug")  
        {
            bugs++; //����������� ������� �� 1
            bugsText.text = bugs.ToString();  //���������� ������
            Destroy(coll.gameObject);  //����������� �������
        }
    }
}
