select c.customerid, c.storeid, c.territoryid 
from customer c
join person p
on c.personid= p.businessentityid;