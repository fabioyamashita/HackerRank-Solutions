SELECT 	CEILING(AVG(CAST(SALARY AS DECIMAL(10,2))) 
		- AVG(CAST(REPLACE(SALARY,'0','') AS DECIMAL(10,2)))) 

FROM EMPLOYEES