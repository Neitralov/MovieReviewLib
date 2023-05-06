window.CalcInputWidthAndSet = (element) => {
    if (element.value != null) {
        if (element.value.length === 0){
            element.size = 12;
        }
        else {
            element.size = element.value.length;
        }
    }
}