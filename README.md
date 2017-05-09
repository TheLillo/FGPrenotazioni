# FGPrenotazioni

## Created By 

* [TheLillo](https://github.com/TheLillo)
* [Fabbrei](https://github.com/Fabbrei)
* [fedefiorini](https://github.com/fedefiorini)


### DESCRIPTION
FGPrenotazioni is the prototype for a management application designed for small companies working in the AV/Lights business, and it is the project related to our Software Engineering course at University of Bologna, Computer Engineering B.Eng.
It is far from being a commercially available tool, but with some adjustments will be on the right track to become it.

The main features are:
* possibility to add and/or remove products to/from the Warehouse. In case of removal, this is possible only if the product is not related to an open rent. 
* generation of a rent or sale transaction, with related invoices (which are slightly different for rents and sales)
* possibility to add and/or remove costumers

This is possible by maintaining a Warehouse as a core part for the products persistence within the application, and by using a simple shopping cart for any transaction/order purpose: by doing this, it is possible to edit the order in any moment before the confirmation, such as any e-commerce application, without modifying the warehouse and its products.

Here there is a simple explanation of the charachterizing elements of the application:
* each product is identified by a string code, formed by three characters and five numbers which indicate the product typology, the brand and the serial number. I.e: API00001 stands for Audio (A), Pioneer (PI), product no. 00001 
* each costumer is identified by his personal code, CF (Fiscal Code, italian) for private costumers and Partita IVA (italian identification number as well) for companies. Each costumer presents a "reliable" field, because rents and sales are not possible for not reliable costumers.
* each product inside the shopping cart is not actually removed from the warehouse, as said before: the removal process takes place only when the order has been confirmed.
* each rent is identified by an unique ID code formed by five numbers. Each one also has two dates (begin of the rent and its end), the costumer/s and a detailed product list.
* each sell only contains the product list and the order date, as there is no need to track sells (but it can be implemented) because only the related invoices are tracked and listed in a riepilogue.
* each invoice is identified by a unique code (progressive number) and there is the possibility to apply fees to the rent invoices, as a costumer can return the products late.

These are some of the main elements of the application, but it is possible to find a more detailed description in the "Application Description" file (.pdf) inside the repository.
For any question, please write us on GitHub or contact us by email.

Federico, Andrea, Fabrizio


## UML Analysis Model
![FGPrenotazioni](http://i.imgur.com/fTvG7rx.png)
## Form view
![FGPrenotazioni](http://i.imgur.com/agqNVPZ.png)

### THANKS 

** Copyright (c) 2016, 2017 TheLillo Fabbrei fedefiorini **
