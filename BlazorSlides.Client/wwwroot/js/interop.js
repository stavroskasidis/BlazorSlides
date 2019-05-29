
var containerReference;
function SetContainterInstance(containerRef) {
    containerReference = containerRef;
}

document.addEventListener("keyup", function (ev) {
    containerReference.invokeMethodAsync('InteropKeyUp', ev.keyCode);
});