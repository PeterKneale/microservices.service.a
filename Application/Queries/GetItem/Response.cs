﻿namespace ServiceA.Application.Queries.GetItem;

public class Response
{
    public Response(string message)
    {
        Message = message;
    }

    public string Message { get; }
}