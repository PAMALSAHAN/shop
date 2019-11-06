VENDOR
------------------------------------
firstname                     String
lastname                      String
commission                    double
each vendor should have a default commission rate   vendor ta sell karana ekn commission ekak add wenna one

track how much to pay the vendor
track how much to pay the store
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




