namespace Mapping;

#region ChangeModel

public static class ChangeModel
{
    #region BlogModel
    public static BlogModel Change(this Tbl_Blog dataModel)
    {
        return new BlogModel()
        {
            BlogId = dataModel.BlogId,
            BlogTitle = dataModel.BlogTitle,
            BlogAuthor = dataModel.BlogAuthor,
            BlogContent = dataModel.BlogContent,
        };
    }

    #endregion
}

#endregion