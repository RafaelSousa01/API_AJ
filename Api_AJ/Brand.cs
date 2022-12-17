namespace API_AJ
{
    class Brand
    {
        public int brandId { get; set; }
        public string brandName { get; set; }
        public string alternativeId { get; set; }
        public string genericId { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public DateTime dataUpdate { get; set; }
        public bool isActive { get; set; }
        public int branchId { get; set; }
    }
}
