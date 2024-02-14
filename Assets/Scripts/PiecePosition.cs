using UnityEngine;

public class PiecePosition : MonoBehaviour
{
    [SerializeField] private GameObject whitePawnPrefab;
    [SerializeField] private GameObject blackPawnPrefab;
    [SerializeField] private GameObject blackKingPrefab;
    [SerializeField] private GameObject whiteKingPrefab;
    [SerializeField] private GameObject blackRookPrefab;
    [SerializeField] private GameObject whiteRookPrefab;
    [SerializeField] private GameObject blackKnightPrefab;
    [SerializeField] private GameObject whiteKnightPrefab;
    [SerializeField] private GameObject blackBishopPrefab;
    [SerializeField] private GameObject whiteBishopPrefab;
    [SerializeField] private GameObject blackQueenPrefab;
    [SerializeField] private GameObject whiteQueenPrefab;
    [SerializeField] private Board board;

    private void Start()
    {
        SetPlayersPawn();
        SetOpponentsPawn();
        SetPlayersSpecialPieces();
        SetOpponentSpecialPieces();
    }

    private void SetPlayersPawn()
    {
        for (int col = 0; col < Board.columnIndex; col++)
        {
            GameObject cell = board.chessboard[6, col];
            GameObject pawn = Instantiate(blackPawnPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
            pawn.name = "Black_pawn_" + col;
        }
    }
    private void SetOpponentsPawn()
    {
        for (int col = 0; col < Board.columnIndex; col++)
        {
            GameObject cell = board.chessboard[1, col];
            GameObject pawn = Instantiate(whitePawnPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
            pawn.name = "White_pawn_" + col;
        }
    }

    private void SetPlayersSpecialPieces()
    {
        for (int col = 0; col < Board.columnIndex; col++)
        {
            GameObject cell = board.chessboard[7, col];
            GameObject piece;
            switch (col)
            {
                case 0:
                case 7:
                    piece = Instantiate(blackRookPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "Black_Rook_" + col;
                    break;
                case 1:
                case 6:
                    piece = Instantiate(blackKnightPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "Black_Knight_" + col;
                    break;
                case 2:
                case 5:
                    piece = Instantiate(blackBishopPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "Black_Bishop_" + col;
                    break;
                case 3:
                    piece = Instantiate(blackKingPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "Black_King_" + col;
                    break;
                case 4:
                    piece = Instantiate(blackQueenPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "Black_Queen_" + col;
                    break;
            }
        }
    }
    private void SetOpponentSpecialPieces()
    {
        for (int col = 0; col < Board.columnIndex; col++)
        {
            GameObject cell = board.chessboard[0, col];
            GameObject piece;
            switch (col)
            {
                case 0:
                case 7:
                    piece = Instantiate(whiteRookPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "White_Rook_" + col;
                    break;
                case 1:
                case 6:
                    piece = Instantiate(whiteKnightPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "White_Knight_" + col;
                    break;
                case 2:
                case 5:
                    piece = Instantiate(whiteBishopPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "White_Bishop_" + col;
                    break;
                case 3:
                    piece = Instantiate(whiteKingPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "White_King_" + col;
                    break;
                case 4:
                    piece = Instantiate(whiteQueenPrefab, cell.transform.position, cell.transform.rotation, cell.transform);
                    piece.name = "White_Queen_" + col;
                    break;
            }
        }
    }
}
