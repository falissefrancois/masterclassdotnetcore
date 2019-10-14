using System;

public class ApplicationRequestContext : IApplicationRequestContext
{
    public Guid Id { get; }

    public ApplicationRequestContext()
    {
        Id = Guid.NewGuid();
    }
}