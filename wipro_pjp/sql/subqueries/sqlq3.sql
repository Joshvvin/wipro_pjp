select p.productid, p.productname from product p where p.productid not in (select s.productid from salesorderheader s);