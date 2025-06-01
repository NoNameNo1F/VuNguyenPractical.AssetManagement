using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Application.Pagination;

public class PagingRequestDto
{
    [Range(1, int.MaxValue)]
    public int PageNumber { get; set; } = 1;
    
    [Range(1, int.MaxValue)]
    public int PageSize { get; set; } = 25;
}