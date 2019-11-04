VENDOR
------------------------------------
firstname                     String
lastname                      String
commission                    double
-----------------------------------
ITEM
------------------------------------
title                        String
description                  String
price                        decimal
sold                         boolean
payment distributed          boolean
owner                        vendor
------------------------------------
STORE
------------------------------------
name                         String
vendors                      Vendor
items                        Item

