DECLARE @ROWS INT = 1;

WHILE @ROWS <= 20
BEGIN
    SELECT REPLICATE('* ', @ROWS);
    SET @ROWS = @ROWS + 1;
END;