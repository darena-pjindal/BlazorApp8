window.callBlazorMethod = (startPosition) => {
    debugger
    DotNet.invokeMethodAsync('BlazorApp8', 'ReturnArrayAsync', startPosition)
        .then(data => {
            console.log(data);
        });
};

function submitForm() {
    // Get the form element by its ID
    var form = document.getElementById('hello');
    form.submit(); // Submit the form
}