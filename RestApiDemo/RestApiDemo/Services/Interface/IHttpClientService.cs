﻿namespace RestApiDemo.Services
{
    public interface IHttpClientService
    {
        Task<string> Post<T1>(T1 requestBody, string requestUrl);
        Task<string> Get(string requestUrl);
    }
}