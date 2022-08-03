select q1.itemname,sum(q1.prodqty) as shopqty,sum(q2.qtytobecollected) as tobecolqty
from stockmast as q1
inner join tobecollected as q2
on q1.prodcode=q2.itemcode
group by q1.itemname
