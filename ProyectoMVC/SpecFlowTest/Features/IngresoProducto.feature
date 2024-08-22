Feature: Ingreso de Productos

A short summary of the feature

@tag1
Scenario: Ingreso de Producto
    Given Llenar los campos de las BDD
    | ProductName | Category   | Price | StockQuantity |
    | Producto1   | Categoría1 | 100.0 | 10            | 

    When El registro se ingresa en la base de datos
    | ProductName | Category   | Price | StockQuantity |
    | Producto1   | Categoría1 | 100.0 | 10            |

    Then El producto con los siguientes detalles se encuentra en la base de dato
    | ProductName | Category   | Price | StockQuantity |
    | Producto1   | Categoría1 | 100.0 | 10            |
