﻿namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class RunningOutMedicineDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }
        public int OptimalQuantity { get; set; }
    }
}
