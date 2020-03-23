namespace Katas
{
    public class kyu6Chess_Fun__1__Chess_Board_Cell_Color
    {
        public bool ChessBoardCellColor(string cell1, string cell2){
            var cell1Bool = ((cell1[0] - 64) % 2 == 1 && int.Parse(cell1[1].ToString()) % 2 == 1) ||
                            ((cell1[0] - 64) % 2 == 0 && int.Parse(cell1[1].ToString()) % 2 == 0);
            var cell2Bool = ((cell2[0] - 64) % 2 == 1 && int.Parse(cell2[1].ToString()) % 2 == 1) ||
                            ((cell2[0] - 64) % 2 == 0 && int.Parse(cell2[1].ToString()) % 2 == 0);
            return (((cell1[0] - 64) % 2 == 1 && int.Parse(cell1[1].ToString()) % 2 == 1) ||
                   ((cell1[0] - 64) % 2 == 0 && int.Parse(cell1[1].ToString()) % 2 == 0)) ==
                   (((cell2[0] - 64) % 2 == 1 && int.Parse(cell2[1].ToString()) % 2 == 1) ||
                   ((cell2[0] - 64) % 2 == 0 && int.Parse(cell2[1].ToString()) % 2 == 0));
        }
    }
}