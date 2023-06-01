﻿namespace CRUD1.Models
{
    public class ModelProducto
    {
        public int productoID { get; set; }

        public int proveedorID { get; set; }

        public string? nom_producto { get; set; }
        public decimal precio { get; set; }
        
        public int stock { get; set; }

        public string? link_imagen { get; set; }

        public bool onSale { get; set; }

        public decimal precio_promo { get; set; }

    }
}
