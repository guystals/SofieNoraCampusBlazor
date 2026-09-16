using System.ComponentModel.DataAnnotations;

public class Student
{
    public int Id { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public DateTime EnrollmentDate { get; set; }

    public StudentStatus Status { get; set; }
}