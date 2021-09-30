function ToExecuteVibrate(time) {
    if (window.navigator && window.navigator.vibrate)
    {
        navigator.vibrate(time);

        console.log("Running.");

        setInterval(function ()
        {
            console.log("Finished.");
        }, time);
    }
    else
    {
        alert("Ops! Your browser does not support");
    }
}