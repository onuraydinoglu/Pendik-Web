namespace StockManagementConsoleUI;

public record Product (
    int Id,
    string Name,
    double price,
    double stock
);