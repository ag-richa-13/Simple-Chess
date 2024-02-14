using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private GameObject blackCellPrefab;
    [SerializeField] private GameObject whiteCellPrefab;
    [SerializeField] private Transform positionsParent;
    public const int rowIndex = 8;
    public const int columnIndex = 8;
    public GameObject[,] chessboard = new GameObject[rowIndex, columnIndex];

    private void Start()
    {
        CreateChessBoard();
    }

    private void CreateChessBoard()
    {
        for (int row = 0; row < rowIndex; row++)
        {
            for (int col = 0; col < columnIndex; col++)
            {
                GameObject cellPrefab = (row + col) % 2 == 0 ? whiteCellPrefab : blackCellPrefab;
                GameObject cell = Instantiate(cellPrefab, positionsParent);
                cell.name = GetCellName(row, col);

                // Calculate position based on row and column
                float xPos = col;
                float yPos = rowIndex - 1 - row; // Invert row to start from bottom
                cell.transform.localPosition = new Vector2(xPos, yPos);

                chessboard[row, col] = cell;
            }
        }
    }
    private string GetCellName(int row, int col)
    {
        string color = (row + col) % 2 == 0 ? "White" : "Black";
        return color + "_Square" + row + "_" + col;
    }
}
