var map;
var poligono = [];
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
    center: {lat: 39.86232, lng:-4.0694706},
    zoom: 15,
	});
	google.maps.event.addListener(map, 'click', function(event) {
	marcador(map, event.latLng)
	});
	
	const drawingManager = new google.maps.drawing.DrawingManager({
    drawingMode: google.maps.drawing.OverlayType.marcador,
    drawingControl: true,
    drawingControlOptions: {
      position: google.maps.ControlPosition.TOP_CENTER,
      drawingModes: [
        
        google.maps.drawing.OverlayType.CIRCLE,
        google.maps.drawing.OverlayType.POLYGON,
        google.maps.drawing.OverlayType.POLYLINE,
        google.maps.drawing.OverlayType.RECTANGLE,
      ],
    },
    
    circleOptions: {
      fillColor: "#ffff00",
      fillOpacity: 1,
      strokeWeight: 5,
      clickable: false,
      editable: true,
      zIndex: 1,
    },
	
	 polygonOptions: {
            fillColor: "#ffff00",
            fillOpacity: .6,
            strokeWeight: 1,
            strokeColor: "#050505",
			strokeOpacity: 1,
			draggable: true,
            clickable: false,
            editable: true,
            zIndex: 1
        }
  });
  drawingManager.setMap(map);
}


function marcador(map, location) {
	var marker = new google.maps.Marker({
	position: location,
	map: map,
	var latitud = position.lat(),
	var longitud = position.lng(),
});


  var infowindow = new google.maps.InfoWindow({
    content: 'Latitude: ' + location.lat() +
    '<br>Longitude: ' + location.lng() 
  });
  infowindow.open(map,marker);
  }