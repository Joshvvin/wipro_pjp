select firstname,lastname,customerid,company from CUSTOMER;
select * from salesorderheader sh join customer c
on c.customerid=sh.salesid;