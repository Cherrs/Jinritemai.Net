using System;
using Jinritemai.Net;

namespace Jinritemai.Net;

public class JinritemaiApiException<T> : Exception
{
    public JinritemaiApiException(Result<T> Result) : base(Result.msg)
    {
    }
}