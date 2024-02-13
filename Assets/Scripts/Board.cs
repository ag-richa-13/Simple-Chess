using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    [SerializeField] private GameObject blackCellPrefab;
    [SerializeField] private GameObject whiteCellPrefab;
    [SerializeField] private Transform positionsParent;

    private const int boardSize = 8;
    private GameObject[,] chessboard = new GameObject[boardSize, boardSize];

    private void Start()
    {
        CreateChessBoard();
    }

    private void CreateChessBoard()
    {
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                GameObject cellPrefab = (row + col) % 2 == 0 ? whiteCellPrefab : blackCellPrefab;
                GameObject cell = Instantiate(cellPrefab, positionsParent);
                cell.name = GetCellName(row, col);

                // Calculate position based on row and column
                float xPos = col;
                float yPos = boardSize - 1 - row; // Invert row to start from bottom
                cell.transform.localPosition = new Vector3(xPos, yPos, 0);

                chessboard[row, col] = cell;
            }
        }
    }

    private string GetCellName(int row, int col)
    {
        string color = (row + col) % 2 == 0 ? "White" : "Black";
        return $"{color}_Cell_{row}_{col}";
    }
}
