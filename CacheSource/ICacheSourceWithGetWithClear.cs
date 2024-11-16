﻿namespace CacheManager.CacheSource;

/// <summary>
/// Base interface of cache provider with clear ability
/// </summary>
/// <typeparam name="T">Item to cache</typeparam>
public interface ICacheSourceWithGetWithClear<T> : ICacheSourceWithGet<T>
{
    /// <summary>
    /// Clear from cache with key
    /// </summary>
    /// <param name="key"></param>
    Task ClearAsync(string key);
}