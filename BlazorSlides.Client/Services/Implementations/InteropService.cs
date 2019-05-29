using BlazorSlides.Client.Services.Contracts;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSlides.Client.Services.Implementations
{
    public class InteropService : IInteropService
    {
        [JSInvokable]
        public void InteropDocumentKeyUp(int keyCode)
        {
            OnDocumentKeyUp?.Invoke(keyCode);
        }

        public event Action<int> OnDocumentKeyUp;
    }
}
