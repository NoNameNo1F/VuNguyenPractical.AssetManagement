using System.Linq.Expressions;

namespace AssetManagement.Application.Utils;

public class FilterUtils<TEntity> where TEntity : class
{
    public static Expression<Func<TEntity, bool>>? CreateEqualFilter(IDictionary<string, object> filters)
    {
        var param = Expression.Parameter(typeof(TEntity), "p");
        Expression? body = null;
        foreach (var pair in filters)
        {
            var member = Expression.Property(param, pair.Key);
            var value = Expression.Constant(pair.Value);
            var expression = Expression.Equal(member, value);

            body = body == null ? expression : Expression.AndAlso(body, expression);
        }

        return body == null ? param => true : Expression.Lambda<Func<TEntity, bool>>(body, param);
    }
}