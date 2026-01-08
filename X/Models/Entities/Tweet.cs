using System.ComponentModel.DataAnnotations;
namespace X.Models.Entities;
public class Tweet
{
    public int Id { get; set; }
    [Required, MaxLength(280)]
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }
}