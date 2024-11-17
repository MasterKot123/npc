using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PamPam : MonoBehaviour
{
 //Health NPC
        public int health = 5;
//Level NPC
        public int level = 1;
    //Speed NPC
        public int speed = 1;
    public int maxHealth = 100; // Максимальное значение здоровья
    private int currentHealth;  // Текущее значение здоровья
    public float moveSpeed = 5f; // Скорость передвижения
    void Start()
    {

        ResetHealth(); // Обновляем здоровье при старте сцены;

    }

    // Метод для сброса здоровья до максимального значения
    public void ResetHealth()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}

