using System.ComponentModel.DataAnnotations;

namespace dotnet_lab4_database.Components
{
    public class DbAlbum
    {

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }
    public string? Genre { get; set; }
    [DataType(DataType.Date)]
    public string? ReleaseDate { get; set; }
    public string? Description { get; set; }
    public float Rate { get; set; }
    public string? Url { get; set; }
        public int RateCount { get; set; } = 0;

    }

}