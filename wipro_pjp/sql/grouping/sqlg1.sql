select productid, productname, count(productid) from salesorderdetail group by productid;