Backend-CSharp-Project
======================

This is a C# project, that had been created as a part of final exam project in Web Programming Back-end course for Bachelor in Web Development programme at (UCN) University College Northern Denmark.

Requirement Specification:

The company Andersen ApS are receiving orders from customers and handles these orders. As part of an IT-solution you are to develop part of the back-end of the system. The system is to handle information about customers, items and orders.

Exercise 1: The classes Customer and Item: Firstly implement the classes Customer and Item. Attributes are shown in the class diagram. Add constructors and properties for all attributes, itemNo and custNo should be read-only.

Exercise 2: The class OrderLine: The association to Item is to be implemented by a reference from OrderLine to Item – as shown in the class diagram. The attribute qty is the number of items wanted of the item. Implement class OrderLine.

Exercise 3: The class Order: The association from Order to Customer is to be implemented by a reference from Order to Customer. The aggregation of order lines in Order is to be implemented by a List in Order. The method AddOrderLine in Order adds an order line to the order. Now a method getTotalPrice is to be implemented on Order. It is to return the total price of the order.

