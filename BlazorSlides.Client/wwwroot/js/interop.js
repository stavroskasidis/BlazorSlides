
var interopServiceReference;
function SetInteropServiceReference(dotnetReference) {
    interopServiceReference = dotnetReference;
}

document.addEventListener("keyup", function (ev) {
    interopServiceReference.invokeMethodAsync('InteropDocumentKeyUp', ev.keyCode);
});