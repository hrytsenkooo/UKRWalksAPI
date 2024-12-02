using System.ComponentModel.DataAnnotations;

namespace UKRWalks.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required]
        [MinLength(4, ErrorMessage = "Code has to be a minimum of 4 characters")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Code has to be a maximum of 100 characters")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
