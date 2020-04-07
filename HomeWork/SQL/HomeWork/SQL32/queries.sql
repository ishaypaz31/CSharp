1.Find the customers who have the maximum number of orders

SELECT CUSTOMER_ID,count(*) AS TOTAL_PRODUCTS, C.NAME
FROM ORDERS AS O JOIN Customer AS C ON C.ID = O.CUSTOMER_ID
GROUP by CUSTOMER_ID
LIMIT 1


2.Find the customer who purchases
His is the highest relative to the other customers

SELECT CUSTOMER_ID,MAX(PRICE) AS TOTAL_PRICE, C.NAME
FROM ORDERS AS O JOIN Customer AS C ON C.ID = O.CUSTOMER_ID JOIN Products AS P ON P.ID = O.CUSTOMER_ID
GROUP by CUSTOMER_ID
LIMIT 1


3.Find customers without orders
SELECT C.name
FROM Customer AS C LEFT JOIN ORDERS AS O ON C.ID = O.CUSTOMER_ID
WHERE O.CUSTOMER_ID IS NULL


5.Generates a query that returns the list of customers for each customer the total amount of orders

SELECT CUSTOMER_ID ,max (PRICE) as total_amount, C.name
FROM ORDERS AS O JOIN Customer AS C ON C.ID = O.CUSTOMER_ID JOIN Products AS P ON P.ID = O.CUSTOMER_ID
GROUP BY CUSTOMER_ID


6.Generates a query that returns the list of customers and for each customer the average amount
His orders

select CUSTOMER_ID, sum(PRICE),c.name
 from  ORDERS AS o join Products AS p on o.PRODUCT_ID = p.ID  join Customer AS c on o.PRODUCT_ID = c.ID 
 group by CUSTOMER_ID


7.Find the list of customers who own the average amount

SELECT CUSTOMER_ID , avg(PRICE) as avgPrice ,C.NAME
FROM (SELECT * FROM ORDERS AS O JOIN Products AS P ON O.PRODUCT_ID = P.ID ORDER BY CUSTOMER_ID)  as  Average 
JOIN Customer as C ON Average.PRODUCT_ID = C.ID
where Average.PRICE > 3000

8.Find the order amount of all customers together

SELECT CUSTOMER_ID as all_cust_together , SUM(PRICE) as Sum_Of_All_orders
FROM (SELECT * FROM ORDERS AS O JOIN Products AS P ON O.PRODUCT_ID = P.ID ORDER BY PRODUCT_ID) 


9. Find the item most frequently ordered

select PRODUCT_ID, max (purchase),P.name as prod_name
 from (select PRODUCT_ID, count(*) as purchase from ORDERS group by PRODUCT_ID) AS TEST JOIN Products AS P ON
 TEST.PRODUCT_ID = P.ID


10.Find the items that were not bought at all

SELECT P.name AS PRODUCT_NAME
FROM Products AS P LEFT JOIN ORDERS AS O ON P.ID = O.PRODUCT_ID
WHERE O.PRODUCT_ID IS NULL
