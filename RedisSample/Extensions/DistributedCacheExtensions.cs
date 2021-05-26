using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RedisSample.Extensions
{
    public static class DistributedCacheExtensions
    {
        public static async Task SetRecordAsync<T>(this IDistributedCache cache, //
            string recordId, // it will be our key ,this is gonna be our unique identifier this cached item, so it can not be changed
            T data, //this is data. so this will be data our cache item
            TimeSpan? absoluteExpireTime = null, 
            TimeSpan? unusedExpireTime = null)
        {
            var options = new DistributedCacheEntryOptions();
             
            options.AbsoluteExpirationRelativeToNow = absoluteExpireTime ?? TimeSpan.FromSeconds(60); //we do not want to have our cache for ever
            //that is why after sometime its time is gonna be expire to use.
            options.SlidingExpiration = unusedExpireTime; //e.g. if you don`t use your cache it will give max you one day. 

            var jsonData = JsonSerializer.Serialize(data);// whatever data is data is, it`s gonna serialize into jsondata.
            await cache.SetStringAsync(recordId, jsonData, options);//saving 
        }

        public static async Task<T> GetRecordAsync<T>(this IDistributedCache cache, string recorId)
        {
            var jsonData = await cache.GetStringAsync(recorId); //give me the key based upon recordid and give it to the jsonData

            if (jsonData is null)
            {
                return default(T); // if it`s null, it is gonna give us default value for T.
            }
            return JsonSerializer.Deserialize<T>(jsonData); //if it`s not null deserialize it into the model you given and return it.
        }
    }
}
