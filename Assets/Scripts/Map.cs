using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // �� �������� �������� ���� using ��� LINQ
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.WSA;

//public class Map
//{
//    private const int Rows = 16;
//    private const int Columns = 16;
//    public Cell[,] Cells { get; private set; }

//    public Map()
//    {
//        Cells = new Cell[Rows, Columns]; // ������������� ������� 16x16
//    }

//    public void AppendCellInMap(int row, int column, Cell cell)
//    {
//        // �������� �� ������� �������
//        if (row < 0 || row >= Rows || column < 0 || column >= Columns)
//        {
//            Debug.LogError("������ ������� �� ������� �������.");
//            return;
//        }

//        Cells[row, column] = cell; // ������������� ������ � �������
//    }

//    public Cell GetCell(int row, int column)
//    {
//        // �������� �� ������� �������
//        if (row < 0 || row >= Rows || column < 0 || column >= Columns)
//        {
//            Debug.LogError("������ ������� �� ������� �������.");
//            return null;
//        }

//        return Cells[row, column]; // ���������� ������ �� �������
//    }

//    public Cell[,] GetSortedCellsByPosition()
//    {
//        // ������� ������ ��� �������� ���� �����
//        List<Cell> cellList = new List<Cell>();

//        // ��������� ��� ������ �� �������
//        for (int row = 0; row < Rows; row++)
//        {
//            for (int column = 0; column < Columns; column++)
//            {
//                Cell cell = Cells[row, column];
//                if (cell != null) // ��������� ������ �������� ������
//                {
//                    cellList.Add(cell);
//                }
//            }
//        }

//        // ��������� ������ �� �������
//        var sortedCells = cellList.OrderBy(cell => cell.Position.magnitude).ToList();

//        // ������� ����� ������� ��� ��������������� �����
//        Cell[,] sortedMatrix = new Cell[Rows, Columns];

//        // ��������� ��������������� �������
//        for (int i = 0; i < sortedCells.Count; i++)
//        {
//            int row = i / Columns; // ���������� ������
//            int column = i % Columns; // ���������� �������

//            if (row < Rows)
//            {
//                sortedMatrix[row, column] = sortedCells[i];
//            }
//        }

//        return sortedMatrix; // ���������� ��������������� �������
//    }
//}

//public class Cell
//{
//    public int Id { get; private set; }
//    public Vector3 Position { get; private set; }

//    public Cell(int id, Vector3 position)
//    {
//        Id = id;
//        Position = position;
//    }
//}

public class TilemapManager : MonoBehaviour
{
    public Tilemap tilemap; // ������ �� ��� Tilemap

    void Start()
    {
        GetAllTiles();
    }

    void GetAllTiles()
    {
        // �������� ������� Tilemap
        BoundsInt bounds = tilemap.cellBounds;

        // ������� �������
        Debug.Log($"Tilemap Bounds: {bounds}");

        // �������� ������ ������
        TileBase[] allTiles = tilemap.GetTilesBlock(bounds);
        Debug.Log($"Total tiles: {allTiles.Length}"); // ������� ����� ���������� ������

        // �������� �� ���� ������ � ������� ����������
        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                // ��� 3D ������ ���������� z ���������� (���� ��� ���������)
                for (int z = 0; z < bounds.size.z; z++)
                {
                    TileBase tile = allTiles[x + y * bounds.size.x + z * bounds.size.x * bounds.size.y];
                    if (tile != null)
                    {
                        Debug.Log($"Tile at ({x}, {y}, {z}): {tile.name}");
                    }
                }
            }
        }
    }
}