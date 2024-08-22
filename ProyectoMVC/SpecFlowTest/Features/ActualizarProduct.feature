Feature: ActualizarProduct

A short summary of the feature

@tag1
  Scenario: Actualizar los detalles de un producto existente
    Given El producto con los siguientes detalles está en la base de datos
      | ProductName    | Category  | Price | StockQuantity |
      | Ergonomic Desk | Furniture | 199.99  | 15            |
    When Actualizo el producto con los siguientes detalles
      | ProductName    | Category  | Price | StockQuantity |
      | Ergonomic Desk | Furniture | 100   | 15            |
    Then El producto debería tener los siguientes detalles actualizados
      | ProductName    | Category  | Price | StockQuantity |
      | Ergonomic Desk | Furniture | 100   | 15            |
