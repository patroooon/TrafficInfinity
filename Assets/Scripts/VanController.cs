using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShadowChimera
{
    public class VanController : MonoBehaviour
    {
       
            public float speed = 5.0f; // Скорость движения объекта
            public Vector3 direction = Vector3.right; // Направление движения объекта

            private void Start()
            {
                StartCoroutine(MoveCoroutine());
            }

            // Корутина для движения объекта через случайные временные промежутки
            IEnumerator MoveCoroutine()
            {
                while (true)
                {
                    yield return new WaitForSeconds(Random.Range(1, 3)); // Случайное время ожидания от 1 до 3 секунд
                    transform.position += direction * speed * Time.deltaTime; // Движение объекта
                }
            }
        }
    }
