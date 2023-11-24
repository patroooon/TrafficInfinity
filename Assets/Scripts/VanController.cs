using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShadowChimera
{
    public class VanController : MonoBehaviour
    {
       
            public float speed = 5.0f; // �������� �������� �������
            public Vector3 direction = Vector3.right; // ����������� �������� �������

            private void Start()
            {
                StartCoroutine(MoveCoroutine());
            }

            // �������� ��� �������� ������� ����� ��������� ��������� ����������
            IEnumerator MoveCoroutine()
            {
                while (true)
                {
                    yield return new WaitForSeconds(Random.Range(1, 3)); // ��������� ����� �������� �� 1 �� 3 ������
                    transform.position += direction * speed * Time.deltaTime; // �������� �������
                }
            }
        }
    }
