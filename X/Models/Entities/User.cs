using System.ComponentModel.DataAnnotations;
namespace X.Models.Entities;
public class User
{
    public int Id { get; set; }
    [Required, MaxLength(30)]
    public string Username { get; set; } = string.Empty;
    [Required]
    public string PasswordHash { get; set; } = string.Empty;
    [Required, MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    [MaxLength(50)]
    public string DisplayName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Tweet> Tweets { get; set; } = new();
}