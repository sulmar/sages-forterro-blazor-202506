window.getLocation = (dotnet) => {

    if (!navigator.geolocation) {
        console.warn("Geolokacja niedostępna.");
        return;
    }

    navigator.geolocation.getCurrentPosition(
        (position) => {
            const lat = position.coords.latitude;
            const lng = position.coords.longitude;

            console.log(lat);
            console.log(lng);

            dotnet.invokeMethodAsync("OnLocationReceived", lat, lng);
        },

        (error) => {
            console.error(error);
        }
    )
    
}