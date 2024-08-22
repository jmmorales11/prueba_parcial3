Feature: EliminarProducto

A short summary of the feature

@tag1
Scenario: Eliminar el producto
	Given Buscar en la bdd
	| ProductName          | Category    | Price | StockQuantity |
	| Bluetooth Headphones | Electronics | 79.99 | 0             |
	When Eliminar de la bdd
	| ProductName          | Category    | Price | StockQuantity |
	| Bluetooth Headphones | Electronics | 79.99 | 0             |
	Then Que ya no exista en la bdd
	| ProductName          | Category    | Price | StockQuantity |
	| Bluetooth Headphones | Electronics | 79.99 | 0             |
