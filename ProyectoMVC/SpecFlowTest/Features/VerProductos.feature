Feature: Leer Productos

  Scenario: Verificar la lista de todos los productos
    Given Existen los siguientes productos en la base de datos
      | ProductName          | Category    | Price   | StockQuantity |
      | Laptop Pro X         | Electronics | 1500.00 | 25            |
      | Wireless Mouse       | Accessories | 25.99   | 100           |
      | Gaming Monitor       | Electronics | 299.99  | 30            |
      | Office Chair         | Furniture   | 89.95   | 10            |
      | USB-C Hub            | Accessories | 45.50   | 50            |
      | Bluetooth Headphones | Electronics | 79.99   | 0             |  
      | Ergonomic Desk       | Furniture   | 199.99  | 15            |
    When Solicito la lista de productos
    Then Debería ver los siguientes productos en la lista
      | ProductName          | Category    | Price   | StockQuantity |
      | Laptop Pro X         | Electronics | 1500.00 | 25            |
      | Wireless Mouse       | Accessories | 25.99   | 100           |
      | Gaming Monitor       | Electronics | 299.99  | 30            |
      | Office Chair         | Furniture   | 89.95   | 10            |
      | USB-C Hub            | Accessories | 45.50   | 50            |
      | Bluetooth Headphones | Electronics | 79.99   | 0             |
      | Ergonomic Desk       | Furniture   | 199.99  | 15            |
