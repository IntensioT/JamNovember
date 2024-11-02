using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCell : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "LavaCell":
                HealPlayer(collision.gameObject);
                break;

            case "WaterCell":
                Die(collision.gameObject);
                break;

            case "FireCell":
                //HealPlayer(collision.gameObject);
                break;

            case "GrassCell":
                TakeDamage(collision.gameObject);
                break;

            case "BorderCell":
                StopPlayer(collision.gameObject);
                break;

            default:
                HandleDefaultCollision(collision.gameObject);
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "LavaCell":
                HealPlayer(other.gameObject);
                break;

            case "WaterCell":
                Die(other.gameObject);
                break;

            case "FireCell":
                //HealPlayer(collision.gameObject);
                break;

            case "GrassCell":
                TakeDamage(other.gameObject);
                break;

            case "BorderCell":
                StopPlayer(other.gameObject);
                break;

            default:
                HandleDefaultCollision(other.gameObject);
                break;
        }
    }

    // ���������� ������������ � ������
    private void TakeDamage(GameObject enemy)
    {
        Debug.Log("damage received");
        // ����� ����� �������� ������ ��� �����, ��������, ���������� ��������
    }

    // ���������� ������������ � ������������
    private void StopPlayer(GameObject obstacle)
    {
        Debug.Log("player stop");
        // ������ ��� ��������� ������������ � ������������
    }

    // ���������� ������������ � ���������
    private void HealPlayer(GameObject powerUp)
    {
        Debug.Log("hp heal");
        // ������ ��� ��������� ��������, ��������, ���������� ���� ��� ��������
    }

    // ���������� ������������ � ���������
    private void Die(GameObject powerUp)
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
