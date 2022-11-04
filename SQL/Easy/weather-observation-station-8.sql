SELECT 	DISTINCT CITY 

FROM 	STATION 

WHERE 	LOWER(RIGHT(CITY,1)) IN ('a','e','i','o','u') 
		AND LOWER(LEFT(CITY,1)) IN ('a','e','i','o','u');