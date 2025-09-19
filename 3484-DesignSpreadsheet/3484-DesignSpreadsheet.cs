// Last updated: 9/19/2025, 9:55:55 PM
public class Spreadsheet {
    private readonly int[,] sheet;
    public Spreadsheet(int rows) {
        this.sheet=new int[rows,26];
    }
    
    // All operations take O(1)
    // Cons: need to block whole sheet memory even if not all is used.
    // needing more size will need another huge array, so not scalable
    // mandates homogeneous data.
    public void SetCell(string cell, int value) {
        var (row,col) = ParseCell(cell);
        sheet[row,col]=value;
    }
    
    private (int row,int col) ParseCell(string cell){
        var col=cell[0]-'A';
        var row=int.Parse(cell.Substring(1))-1;
        Console.WriteLine(cell+"\t"+ col +"\r"+row);
        return (row,col);
    }
    public void ResetCell(string cell) {
        var (row,col) = ParseCell(cell);
        sheet[row,col]=0;
    }
    
    public int GetValue(string formula) {
        if(!formula.StartsWith('=')) return 0;
        var parts=formula.Substring(1).Split('+');
        return GetCellValueFromReference(parts[0])+GetCellValueFromReference(parts[1]);
    }

    private int GetCellValueFromReference(string cell){
        // find if its cel reference like A1 or just a number, eg.  6
        if(char.IsLetter(cell[0])){ //A..Z
            var (row,col)=ParseCell(cell);
            return sheet[row,col];
        }
        return int.Parse(cell);  // its a number
    }
}

/**
 * Your Spreadsheet object will be instantiated and called as such:
 * Spreadsheet obj = new Spreadsheet(rows);
 * obj.SetCell(cell,value);
 * obj.ResetCell(cell);
 * int param_3 = obj.GetValue(formula);
 */
