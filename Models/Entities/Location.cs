﻿namespace storageApi;

public class Location
{
    public int LocationId { get; set; }
    public string LocationName { get; set; } = string.Empty;
    public string LocationAddress { get; set; } = string.Empty;
    public virtual ICollection<Warehouse> Warehouses { get; set; } = null!;
}
