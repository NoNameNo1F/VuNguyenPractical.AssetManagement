namespace AssetManagement.Application.Common;

public class PagedResult<T>
{
    public IEnumerable<T> Items { get; set; }
    public PageData PageData { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public PagedResult()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
    }

    public PagedResult(IEnumerable<T> items, int pageNumber, int pageSize, int totalCount)
    {
        Items = items;
        PageData = new PageData(pageNumber, pageSize, totalCount);
    }
}