using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexogenChange : MonoBehaviour
{
    [SerializeField] private GameObject _newObject; // ����� ������ ��� ������

    public void ReplaceObjectAtPosition(GameObject targetObject)
    {
        if (targetObject != null && _newObject != null)
        {
            // ��������� ������� � ������� �������� �������
            Vector3 position = targetObject.transform.position;
            Quaternion rotation = targetObject.transform.rotation;

            // ������� ������� ������
            Destroy(targetObject);

            // ������� ����� ������ �� ����� ����������
            Instantiate(_newObject, position, rotation);

            Debug.Log("Object replaced with new object at the same position.");
        }
        else
        {
            Debug.LogWarning("Target object or new object reference is missing.");
        }
    }
}
