
function connectFour(board) {
    var whole = "";
    for(var y = 5; y >= 0; y--)
    {
        whole += board[y].join().replace(/[,\-]/gi, "") + "|";
    }
    for(var x = 0; x < 7; x++)
    {
        for (var y = 0; y < 6; y++) whole += board[y][x].replace(/[,\-]/gi, "");
        whole += "|";
    }
    for (var Y = 2; Y >= 0 ; Y--)
    {
        for (var y = Y, x = 0; y < 6; y++, x++) whole += board[y][x].replace(/[,\-]/gi, "");
        whole += ("|");
    }
    for (var X = 1; X < 4; X++)
    {
        for (var y = 0, x = X; x < 7; y++, x++) whole += board[y][x].replace(/[,\-]/gi, "");
        whole += ("|");
    }
    for (var Y = 2; Y >= 0 ; Y--)
    {
        for (var y = Y, x = 6; y < 6; y++, x--) whole += board[y][x].replace(/[,\-]/gi, "");
        whole += ("|");
    }
    for (var X = 5; X > 2; X--)
    {
        for (var y = 0, x = X; x >= 0; y++, x--) whole += board[y][x].replace(/[,\-]/gi, "");
        whole += ("|");
    }
    var inProgressTest = false;
    for (let y = 0; y < board.length; y++) {
        for (let x = 0; x < board[y].length; x++) {
            if(board[y][x] === '-'){
                inProgressTest = true;
                break;
            }
        }
        if(inProgressTest) break;
    }
    console.log(inProgressTest);
    var yellow = /(Y){4}/i;
    var red = /(R){4}/i;
    if(yellow.test(whole) && red.test(whole)) return"draw";
    if(!yellow.test(whole) && !red.test(whole) && !inProgressTest) return"draw";
    if(yellow.test(whole)) return"Y";
    if(red.test(whole)) return"R";
    if(inProgressTest) return "in progress";
}

var board = [['-','-','-','-','-','-','-'],
             ['-','-','-','-','-','-','-'],
             ['-','-','-','R','R','R','R'],
             ['-','-','-','Y','Y','R','Y'],
             ['-','-','-','Y','R','Y','Y'],
             ['-','-','Y','Y','R','R','R']];
var board2 = [['-','Y','-','-','-','-','-'],
              ['-','Y','-','-','-','-','-'],
              ['R','Y','-','-','-','-','-'],
              ['Y','Y','-','-','-','-','-'],
              ['Y','R','Y','-','-','-','-'],
              ['Y','Y','Y','R','Y','R','R']];


console.log(connectFour(board2));

