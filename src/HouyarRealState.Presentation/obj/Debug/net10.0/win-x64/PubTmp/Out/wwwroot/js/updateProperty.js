$(document).ready(function () {

    let map = null;
    let marker = null;

    // Default location: Tehran
    const defaultLat = 29.7022154;
    const defaultLng = 52.4752522;

    const modal = $('#modalMap');

    const latitudeInput = $('#Latitude');
    const longitudeInput = $('#Longitude');

    // Initialize map only once
    function initializeMap() {

        if (map !== null) {
            return;
        }

        map = L.map('map').setView(
            [defaultLat, defaultLng],
            13
        );

        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
            attribution: '&copy; OpenStreetMap contributors'
        }).addTo(map);

        // Click on map
        map.on('click', function (e) {

            setMarker(e.latlng.lat, e.latlng.lng);

        });

    }



    // Custom Leaflet marker icon
    const propertyMarkerIcon = L.icon({
        iconUrl: '/img/map/marker.png',

        iconSize: [42, 42],
        iconAnchor: [16, 42],

        popupAnchor: [0, -42]
    });


    // Create or update marker
    function setMarker(lat, lng) {

        const position = [lat, lng];

        if (marker === null) {

            marker = L.marker(position, {
                draggable: true,
                icon: propertyMarkerIcon
            }).addTo(map);

            marker.on('dragend', function () {

                const newPosition = marker.getLatLng();

                console.log('Latitude:', newPosition.lat);
                console.log('Longitude:', newPosition.lng);

            });

        } else {

            marker.setLatLng(position);

        }

        map.panTo(position);
    }

    // When modal opens
    modal.on('shown.bs.modal', function () {

        initializeMap();

        // Fix map rendering inside modal
        setTimeout(function () {

            map.invalidateSize();

            const lat = parseFloat(latitudeInput.val());
            const lng = parseFloat(longitudeInput.val());

            // Use existing form coordinates if valid
            if (
                !isNaN(lat) &&
                !isNaN(lng) &&
                lat >= -90 &&
                lat <= 90 &&
                lng >= -180 &&
                lng <= 180
            ) {

                setMarker(lat, lng);
                map.setView([lat, lng], 16);

            } else {

                map.setView([defaultLat, defaultLng], 13);

            }

        }, 200);

    });

    // Select location button
    $(".btn-set-location").click(function (e) {


        if (marker === null) {
            toastr.info("ابتدا یک موقعیت روی نقشه انتخاب کنید")
            return;
        }

        const position = marker.getLatLng();

        // Transfer coordinates to main form
        latitudeInput.val(position.lat.toFixed(7));
        longitudeInput.val(position.lng.toFixed(7));

        // Close modal
        modal.modal('hide');
    })

});


$("#frmUpdateProperty").submit(function (e) {

    e.preventDefault();

    var model = new FormData(this);

    $(".submitWating").removeClass("hidden");
    $(".submit").addClass("hidden");

    $.ajax({
        type: "POST",
        data: model,
        url: "/Property/UpdateProperty",
        processData: false,
        contentType: false,
        cache: false,
        success: function (d) {

            if (d.status == true) // Message Sent? Show the 'Thank You' message and hide the form
            {
                toastr.success(d.message);
                window.location.href = "/Properties";
            }

            else {
                $(".submit").removeClass("hidden");
                $(".submitWating").addClass("hidden");
                toastr.error(d.message);
            }

        }
    })

});



