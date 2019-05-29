using System;

namespace BlazorSlides.Client.Services.Contracts
{
    public interface IInteropService
    {
        event Action<int> OnDocumentKeyUp;
        void InteropDocumentKeyUp(int keyCode);
    }
}