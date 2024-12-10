namespace Domain;

public class classroom
{
    public int classroom_id { get; set; }
    public int capacity { get; set; }
    public int room_type { get; set; }
    public string description { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}