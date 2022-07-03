﻿SELECT p.product_name, c.category_name
FROM product p
         LEFT JOIN product_category pc
                   ON pc.product_id = p.product_id
         LEFT JOIN category c
                   ON pc.category_id = c.category_id;