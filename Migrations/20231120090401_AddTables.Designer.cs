﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using storageApi;

#nullable disable

namespace storageApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231120090401_AddTables")]
    partial class AddTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("storageApi.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("storageApi.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DeliveryId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("storageApi.DeliveryDetail", b =>
                {
                    b.Property<int>("DeliveryDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryDetailId"));

                    b.Property<DateTime>("ActualDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("DeliveryDetailId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("DeliveryDetails");
                });

            modelBuilder.Entity("storageApi.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<int>("MaximumStockLevel")
                        .HasColumnType("int");

                    b.Property<int>("MinimumStockLevel")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<int>("ReorderPoint")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("storageApi.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("LocationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("storageApi.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("storageApi.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<DateTime>("ActualDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("storageApi.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRefrigerated")
                        .HasColumnType("bit");

                    b.Property<int>("PackedDepth")
                        .HasColumnType("int");

                    b.Property<int>("PackedHeight")
                        .HasColumnType("int");

                    b.Property<int>("PackedWeight")
                        .HasColumnType("int");

                    b.Property<int>("PackedWidth")
                        .HasColumnType("int");

                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReorderQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("storageApi.Provider", b =>
                {
                    b.Property<int>("ProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProviderId"));

                    b.Property<string>("ProviderAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderWeb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProviderId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("storageApi.Transfer", b =>
                {
                    b.Property<int>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferId"));

                    b.Property<int>("DestinyId")
                        .HasColumnType("int");

                    b.Property<int>("OriginId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransferQuantity")
                        .HasColumnType("int");

                    b.HasKey("TransferId");

                    b.HasIndex("DestinyId");

                    b.HasIndex("OriginId");

                    b.HasIndex("ProductId");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("storageApi.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseId"));

                    b.Property<string>("IsRefrigerated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.HasIndex("LocationId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("storageApi.Delivery", b =>
                {
                    b.HasOne("storageApi.Customer", "Customer")
                        .WithMany("Deliveries")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("storageApi.DeliveryDetail", b =>
                {
                    b.HasOne("storageApi.Delivery", null)
                        .WithMany("DeliveryDetails")
                        .HasForeignKey("DeliveryId");

                    b.HasOne("storageApi.Product", "Product")
                        .WithMany("DeliveryDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("storageApi.Warehouse", "Warehouse")
                        .WithMany("DeliveryDetails")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("storageApi.Inventory", b =>
                {
                    b.HasOne("storageApi.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("storageApi.Warehouse", "Warehouse")
                        .WithMany("Inventories")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("storageApi.Order", b =>
                {
                    b.HasOne("storageApi.Provider", "Provider")
                        .WithMany("Orders")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("storageApi.OrderDetail", b =>
                {
                    b.HasOne("storageApi.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("storageApi.Product", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId");

                    b.HasOne("storageApi.Warehouse", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("storageApi.Transfer", b =>
                {
                    b.HasOne("storageApi.Warehouse", "Destiny")
                        .WithMany("Destinies")
                        .HasForeignKey("DestinyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("storageApi.Warehouse", "Origin")
                        .WithMany("Origins")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("storageApi.Product", "Product")
                        .WithMany("Transfers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destiny");

                    b.Navigation("Origin");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("storageApi.Warehouse", b =>
                {
                    b.HasOne("storageApi.Location", "Location")
                        .WithMany("Warehouses")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("storageApi.Customer", b =>
                {
                    b.Navigation("Deliveries");
                });

            modelBuilder.Entity("storageApi.Delivery", b =>
                {
                    b.Navigation("DeliveryDetails");
                });

            modelBuilder.Entity("storageApi.Location", b =>
                {
                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("storageApi.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("storageApi.Product", b =>
                {
                    b.Navigation("DeliveryDetails");

                    b.Navigation("Inventories");

                    b.Navigation("OrderDetails");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("storageApi.Provider", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("storageApi.Warehouse", b =>
                {
                    b.Navigation("DeliveryDetails");

                    b.Navigation("Destinies");

                    b.Navigation("Inventories");

                    b.Navigation("OrderDetails");

                    b.Navigation("Origins");
                });
#pragma warning restore 612, 618
        }
    }
}
