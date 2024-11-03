using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCell : MonoBehaviour
{
    private int hp = 3;

    void Update()
    {
        if (hp <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collision");
        switch (collision.gameObject.tag)
        {
            case "LavaCell":
                HealPlayer();
                break;

            case "WaterCell":
                Die();
                break;

            case "FireCell":
                //HealPlayer(collision.gameObject);
                break;

            case "GrassCell":
                TakeDamage();
                break;

            case "BorderCell":
                StopPlayer(collision.gameObject);
                break;

            default:
                HandleDefaultCollision(collision.gameObject);
                break;
        }
    }

    // ���������� ������������ � ������
    private void TakeDamage()
    {
        Debug.Log($"hp {hp}");
        Debug.Log("damage received");
        hp--;
        // ����� ����� �������� ������ ��� �����, ��������, ���������� ��������
    }

    // ���������� ������������ � ������������
    private void StopPlayer(GameObject obstacle)
    {
        Debug.Log("player stop");
        // ������ ��� ��������� ������������ � ������������
    }

    // ���������� ������������ � ���������
    private void HealPlayer()
    {
        Debug.Log($"hp {hp}");
        Debug.Log("hp heal");
        hp += 3;
        // ������ ��� ��������� ��������, ��������, ���������� ���� ��� ��������
    }

    // ���������� ������������ � ���������
    private void Die()
    {
        Debug.Log("player die");
        // ������ ��� ��������� ��������, ��������, ���������� ���� ��� ��������
    }

    private void HandleDefaultCollision(GameObject other)
    {
        Debug.Log("Collision with undefind collider");
        // ������ ��� ����������� ��������
    }
}
