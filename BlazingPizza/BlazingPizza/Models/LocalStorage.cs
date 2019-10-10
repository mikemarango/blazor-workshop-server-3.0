﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Models
{
    public static class LocalStorage
    {
        public static ValueTask<T> GetAsync<T>(IJSRuntime jsRuntime, string key)
            => jsRuntime.InvokeAsync<T>("blazorLocalStorage.get", key);

        public static ValueTask<T> SetAsync<T>(IJSRuntime jsRuntime, string key, object value)
            => jsRuntime.InvokeAsync<T>("blazorLocalStorage.set", key, value);

        public static ValueTask<T> DeleteAsync<T>(IJSRuntime jsRuntime, string key)
            => jsRuntime.InvokeAsync<T>("blazorLocalStorage.delete", key);
    }
}
