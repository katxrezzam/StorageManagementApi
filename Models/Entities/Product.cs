﻿namespace storageApi;

public class Product
{
    public int ProductId { get; set; }
    public int ProductCode { get; set; }
    public string BarCode { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string ProductDescription { get; set; } = string.Empty;
    public int ReorderQuantity { get; set; }
    public int PackedWeight { get; set; }
    public int PackedHeight { get; set; }
    public int PackedWidth { get; set; }
    public int PackedDepth { get; set; }
    public bool IsRefrigerated { get; set; }
    public virtual ICollection<Inventory> Inventories { get; set; } = null!;
    public virtual ICollection<Transfer> Transfers { get; set; } = null!;
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    public virtual ICollection<DeliveryDetail> DeliveryDetails { get; set; } = null!;
}
