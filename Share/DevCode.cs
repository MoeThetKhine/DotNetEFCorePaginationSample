namespace Share;

#region DevCode

public static class DevCode
{
    public static IQueryable<TSource> WithPagination<TSource>
        (this IQueryable<TSource>source,int pageNo,int pageSize)
    {
        return source
            .Skip((pageNo - 1) * pageSize)
            .Take(pageSize);
    }
}

#endregion