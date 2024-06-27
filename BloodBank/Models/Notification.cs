using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Notification
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Message { get; set; }

    [Required]
    public DateTime DateCreated { get; set; }

    public bool IsRead { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User? User { get; set; }
}
