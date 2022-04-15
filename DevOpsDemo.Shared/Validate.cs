using System.Linq.Expressions;

namespace DevOpsDemo.Shared;

public static class Validate
{
    public static T NotNull<T>(Expression<Func<T>> toCheck) where T : class?
    {
        if (toCheck == null)
        {
            throw new NullReferenceException("Null check error - no value given to check for!");
        }

        var result = toCheck.Compile().Invoke();
        if (result == null)
        {
            throw new ArgumentNullException((toCheck.Body as MemberExpression)?.Member.Name);
        }
        return result;
    }
}