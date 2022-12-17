namespace API_AJ.AuthToken
{
    public class UserAuthResponse
    {
        public User user { get; set; }
        public string token { get; set; }
        public DateTime validToken { get; set; }
    }

    public class User
    {
        public int groupId { get; set; }
        public int tenantId { get; set; }
        public int id { get; set; }
        public string userName { get; set; }
        public string emailAddress { get; set; }
        public string urlImage { get; set; }
        public string phone { get; set; }
        public List<int> branchList { get; set; }
        public bool isAdmin { get; set; }
        public bool sysAdmin { get; set; }
        public bool corpAdmin { get; set; }
        public DateTime dataUpdate { get; set; }
        public bool isActive { get; set; }
    }
}
