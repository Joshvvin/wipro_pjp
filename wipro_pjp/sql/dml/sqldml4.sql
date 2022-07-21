delete from democustomer 
where orderid = 'null';
delete from demosalesorderheader 
where sum(totaldue) <= 1000;