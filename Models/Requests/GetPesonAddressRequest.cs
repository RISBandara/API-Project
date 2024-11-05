namespace PersonApi.Models.Requests
{
    public class GetPersonAddressRequest
    {
        public int Id { get; set; }
        public string? Owner { get; set; }
    }
}
