using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WhatCell : MonoBehaviour
{
    private UIPanel _uiPanel;
    private HexogenChange _changeMesh;

    private void Awake()
    {
        _uiPanel = Camera.main.GetComponent<UIPanel>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "LavaCell"://�� �����?
                HealPlayer(collision.gameObject);
                break;

            case "WaterCell":// ������
                Die(collision.gameObject);
                break;

            case "FireCell":// ���������� ����?
                //HealPlayer(collision.gameObject);
                break;

            case "GrassCell":// ����������� ���� �������� �� ���� ���� + ��������� �����
                TakeDamage(collision.gameObject);
                _changeMesh.ChangerMeshGex();
                break;

            case "BorderCell"://????
                StopPlayer(collision.gameObject);
                break;

            case "WinCell":
                WinPoint(collision.gameObject);
                break;

            default:
                HandleDefaultCollision(collision.gameObject);
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
        _uiPanel.Lose();
        // ������ ��� ��������� ��������, ��������, ���������� ���� ��� ��������
    }

    private void WinPoint(GameObject powerUp)
    {
        Debug.Log("player win");
        _uiPanel.Win();
    }

    private void HandleDefaultCollision(GameObject other)
    {
        Debug.Log("Collision with undefind collider");
        // ������ ��� ����������� ��������
    }
}
