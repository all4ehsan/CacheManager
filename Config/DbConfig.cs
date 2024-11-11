﻿namespace CacheManager.Config;

/// <summary>
/// Config of Database cache
/// </summary>
public class DbConfig
{
    /// <summary>
    /// Connection String for db connect
    /// </summary>
    public required string ConnectionString { get; init; }

    /// <summary>
    /// Query that get data from db
    /// </summary>
    public required string Query { get; init; }

    /// <summary>
    /// TimeOut
    /// </summary>
    public int TimeOutOnSecond { get; init; } = 5;
}