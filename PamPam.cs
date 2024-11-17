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
    public int maxHealth = 100; // ������������ �������� ��������
    private int currentHealth;  // ������� �������� ��������
    public float moveSpeed = 5f; // �������� ������������
    void Start()
    {

        ResetHealth(); // ��������� �������� ��� ������ �����;

    }

    // ����� ��� ������ �������� �� ������������� ��������
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

