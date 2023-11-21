namespace storageApi;

public class WarehouseDto
{
    public string WarehouseName { get; set; } = string.Empty;
    public string IsRefrigerated { get; set; } = string.Empty;
    public int LocationId { get; set; }
}
