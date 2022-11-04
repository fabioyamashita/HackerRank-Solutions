SELECT 	DISTINCT CITY 

FROM 	STATION 

WHERE 	LOWER(RIGHT(CITY,1)) NOT IN ('a','e','i','o','u') 
		OR LOWER(LEFT(CITY,1)) NOT IN ('a','e','i','o','u');